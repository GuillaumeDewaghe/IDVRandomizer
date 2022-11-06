using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDVRandomizer.Persona
{
    /// <summary>
    /// Neighbours of a talent
    /// </summary>
    public class Neighbours
    {
        /// <summary>
        /// Parent of a talent
        /// </summary>
        public Talent Parent { get; set; }
        /// <summary>
        /// Children of the talent
        /// </summary>
        public List<Talent> Children { get; set; }

        /// <summary>
        /// Creates a neighbour with values at null
        /// </summary>
        public Neighbours()
        {
            Parent = null;
            Children = new List<Talent>();
        }

        public override string ToString()
        {
            return "Neighbours { Parent = " + Parent + ", Children = " + String.Join(", ", Children) + " }";
        }
    }
}
