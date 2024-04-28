using System;
using System.Drawing;

namespace Planets
{
    [Serializable]
    public class DrawablePlanet : Planet
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private bool visible;
        public bool Visible
        {
            get
            {
                return visible;
            }
            set
            {
                visible = value;
                OnPropertyChanged("Visible");
            }
        }

        private Color color;
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                OnPropertyChanged("Color");
            }
        }

        private const float positionSize = 2.9f;
        private const float pathSize = 1.4f;

        public DrawablePlanet(float distance, float orbitTime, float offset, Planet parent, string name, Color color, bool visible)
            : base(distance, orbitTime, offset, parent)
        {
            this.Name = name;
            this.Color = color;
            this.Visible = visible;
        }

        public void DrawPlanet(Graphics g, float time, float step, Planet viewFrom, float scale, int drawNthPoint)
        {
            if (Visible)
            {
                PointF[] path = GetPath(time, step, viewFrom);
                DrawPath(path, g, scale);

                int count = drawNthPoint;
                foreach (PointF pos in path)
                {
                    if (count == drawNthPoint)
                    {
                        DrawPosition(pos, g, scale);
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
        }

        public PointF[] GetPath(float time, float stepLength, Planet viewFrom)
        {
            PointF[] path = new PointF[(int)Math.Ceiling(time / stepLength)];
            float f = 0;
            for (int i = 0; i < path.Length; i++)
            {
                path[i] = GetRelativePosition(f, viewFrom);
                f += stepLength;
            }
            return path;
        }

        private void DrawPath(PointF[] path, Graphics g, float scale)
        {
            if (path.Length > 1)
            {
                using (Pen pen = new Pen(Color, pathSize / scale)) // Optimise?
                {
                    //g.DrawCurve(pen, path);
                    g.DrawLines(pen, path); // much better performance and can still be accurate with enough points
                }
            }
        }

        private void DrawPosition(PointF pos, Graphics g, float scale)
        {
            using (Brush b = new SolidBrush(Color)) // Optimise?
            {
                g.FillEllipse(b, pos.X - (positionSize/scale) / 2, pos.Y - (positionSize/scale) / 2, positionSize/scale, positionSize/scale);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
