using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Planets
{
    [Serializable]
    public class Planet : INotifyPropertyChanged
    {
        private float distance;
        public float Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
                OnPropertyChanged("Distance");
            }
        }

        private float orbitTime;
        public float OrbitTime
        {
            get
            {
                return orbitTime;
            }
            set
            {
                orbitTime = value;
                OnPropertyChanged("OrbitTime");
            }
        }

        private float offset;
        public float Offset
        {
            get
            {
                return offset;
            }
            set
            {
                offset = value;
                OnPropertyChanged("Offset");
            }
        }

        private Planet parent;
        public Planet Parent
        {
            get
            {
                return parent;
            }
            set
            {

                if (!CanBeParent(value))
                    throw new ArgumentException("You have assigned a child of this planet as its parent.");
                parent = value;
                OnPropertyChanged("Parent");
            }
        }

        public Planet() { }

        public Planet(float distance, float orbitTime, float offset, Planet parent)
        {
            this.Distance = distance;
            this.OrbitTime = orbitTime;
            this.Offset = offset;
            this.Parent = parent;
        }

        public PointF GetPosition(float time)
        {
            if (parent == null)
                return new PointF(0, 0);
            PointF parentPosition;
            parentPosition = Parent.GetPosition(time);
            float angle = (float)(Math.PI / 180) * (360 / OrbitTime * (time + offset));
            PointF position = new PointF
                (parentPosition.X + Distance * (float)Math.Cos(angle),
                 parentPosition.Y + Distance * (float)Math.Sin(angle));
            return position;
        }

        public PointF GetRelativePosition(float time, Planet viewFrom)
        {
            PointF viewFromPosition = viewFrom.GetPosition(time);
            PointF thisPosition = GetPosition(time);
            PointF relativePosition = new PointF
                (viewFromPosition.X - thisPosition.X,
                 viewFromPosition.Y - thisPosition.Y);
            return relativePosition;
        }

        public bool CanBeParent(Planet newParent)
        {
            if (newParent == null)
                return true;
            if (newParent == this)
                return false;
            return CanBeParent(newParent.Parent);
        }

        public float GetMaxDistance()
        {
            float parentDistance = 0;
            if (Parent != null)
                parentDistance = Parent.GetMaxDistance();
            float distance = parentDistance + Math.Abs(this.Distance);
            return distance;
        }

        [field:NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}