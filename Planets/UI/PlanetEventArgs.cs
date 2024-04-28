using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Planets
{
    public class PlanetEventArgs : EventArgs
    {
        public DrawablePlanet planet;

        public PlanetEventArgs(DrawablePlanet planet)
        {
            this.planet = planet;
        }
    }
}
