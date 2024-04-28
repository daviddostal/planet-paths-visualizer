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
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private bool visible;
        public bool Visible
        {
            get => visible;
            set
            {
                visible = value;
                OnPropertyChanged("Visible");
            }
        }

        private Color color;
        public Color Color
        {
            get => color;
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
            float time = 0;
            for (int i = 0; i < path.Length; i++)
            {
                path[i] = GetRelativePosition(time, viewFrom);
                time += stepLength;
            }
            return path;
        }

        private void DrawPath(PointF[] path, Graphics g, float scale)
        {
            if (path.Length > 1)
            {
                // TODO: optimise by reusing pens with same color
                using (Pen pen = new Pen(Color, pathSize / scale))
                {
                    // Although DrawLines() can only draw straight lines between points, it has
                    // much better performance than DrawCurve() and can still be accurate
                    // if the points are dense enough.
                    g.DrawLines(pen, path);
                }
            }
        }

        private void DrawPosition(PointF pos, Graphics g, float scale)
        {
            float diameter = positionSize / scale;
            float radius = diameter / 2;
            
            // TODO: optimise by reusing brushes with same color
            using (Brush b = new SolidBrush(Color))
            {
                g.FillEllipse(b, pos.X - radius, pos.Y - radius, diameter, diameter);
            }
        }

        public override string ToString() =>  Name;
    }
}
