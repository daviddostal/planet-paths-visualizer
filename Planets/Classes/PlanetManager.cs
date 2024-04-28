using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;

namespace Planets
{
    public class PlanetManager : INotifyPropertyChanged
    {
        private float time;
        public float Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
                OnPropertyChanged("Time");
            }
        }

        private float step;
        public float Step
        {
            get
            {
                return step;
            }
            set
            {
                step = value;
                OnPropertyChanged("Step");
            }
        }

        private Planet viewFrom;
        public Planet ViewFrom
        {
            get
            {
                return viewFrom;
            }
            set
            {
                viewFrom = value;
                OnPropertyChanged("ViewFrom");
            }
        }

        public BindingList<DrawablePlanet> Planets { get; private set; }

        private float zoom;
        public float Zoom
        {
            get
            {
                return zoom;
            }
            set
            {
                zoom = value;
                OnPropertyChanged("Zoom");
            }
        }

        private int drawNthPoint;
        public int DrawNthPoint
        {
            get
            {
                return drawNthPoint;
            }
            set
            {
                drawNthPoint = value;
                OnPropertyChanged("DrawNthPoint");
            }
        }

        public PlanetManager()
        {
            Planets = new BindingList<DrawablePlanet>();
        }

        public void AddPlanet(DrawablePlanet p)
        {
            Planets.Add(p);
            OnPlanetAdded(p);
        }

        public void RemovePlanet(DrawablePlanet p)
        {
            Planets.Remove(p);
        }

        public Image DrawPlanets(Image img)
        {
            Debug.WriteLine("{1} {0} DrawPlanets started.", DateTime.Now, Thread.CurrentThread.ManagedThreadId);
            using (Graphics g = Graphics.FromImage(img))
            {
                float pictureSize = g.VisibleClipBounds.Width;
                if (g.VisibleClipBounds.Height < pictureSize)
                {
                    pictureSize = g.VisibleClipBounds.Height;
                }

                g.Clear(Color.Transparent);

                g.TranslateTransform(g.VisibleClipBounds.Width / 2, g.VisibleClipBounds.Height / 2);

                float maxDistance = GetMaxPlanetsDistance();
                float scale = Zoom;
                if (maxDistance != 0)
                {
                    scale = Zoom * pictureSize / (maxDistance * 4);
                }
                g.ScaleTransform(scale, scale);

                for(int i = 0; i < Planets.Count; i++)
                {
                    OnProgressChanged(i);
                    DrawablePlanet p = Planets[i];
                    Debug.WriteLine("{1} {0} Drawing planet {2}.", DateTime.Now, Thread.CurrentThread.ManagedThreadId, p);
                    p.DrawPlanet(g, Time, Step, ViewFrom, scale, DrawNthPoint);
                }
                OnProgressChanged(Planets.Count);
            }
            Debug.WriteLine("{1} {0} DrawPlanets finished.", DateTime.Now, Thread.CurrentThread.ManagedThreadId);
            return img;
        }

        public Task<Image> DrawPlanetsAsync(Image i)
        {
            Debug.WriteLine("{1} {0} DrawPlanetsAsync started.", DateTime.Now, Thread.CurrentThread.ManagedThreadId);
            return Task.Factory.StartNew(() => DrawPlanets(i));
        }

        private float GetMaxPlanetsDistance()
        {
            float maxDistance = 0;
            foreach (DrawablePlanet p in Planets)
            {
                float planetMax = p.GetMaxDistance();
                if (planetMax > maxDistance)
                {
                    maxDistance = planetMax;
                }
            }
            return maxDistance;
        }

        public void Save(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Create))
            {
                PlanetData data = new PlanetData();
                data.Time = Time;
                data.Step = Step;
                data.ViewFrom = ViewFrom;
                data.Planets = Planets;
                data.Zoom = Zoom;
                data.DrawNthPoint = DrawNthPoint;

                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, data);
            }
        }

        public void Load(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                PlanetData data = (PlanetData)formatter.Deserialize(stream);

                Planets.Clear();
                OnPlanetsCleared();
                foreach (DrawablePlanet p in data.Planets)
                {
                    AddPlanet(p);
                }

                Time = data.Time;
                Step = data.Step;
                ViewFrom = data.ViewFrom;
                Zoom = data.Zoom;
                DrawNthPoint = data.DrawNthPoint;
            }
        }

        public event EventHandler<PlanetEventArgs> PlanetAdded;
        internal protected void OnPlanetAdded(DrawablePlanet planet)
        {
            if (PlanetAdded != null)
                PlanetAdded(this, new PlanetEventArgs(planet));
        }

        public event EventHandler<EventArgs> PlanetsCleared;
        internal protected void OnPlanetsCleared()
        {
            if (PlanetsCleared != null)
                PlanetsCleared(this, new EventArgs());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event ProgressChangedEventHandler ProgressChanged;
        protected void OnProgressChanged(int planetCount)
        {
            if (ProgressChanged != null)
                ProgressChanged(this, new ProgressChangedEventArgs((int)Math.Floor(100 * planetCount / (double)Planets.Count), this));
        }

        public void Export(string fileName, Image image, ImageFormat format)
        {
            image.Save(fileName, format);
        }

        [Serializable]
        private class PlanetData
        {
            public float Time { get; set; }

            public float Step { get; set; }

            public Planet ViewFrom { get; set; }

            public float Zoom { get; set; }

            public int DrawNthPoint { get; set; }

            public BindingList<DrawablePlanet> Planets { get; set; }
        }
    }
}