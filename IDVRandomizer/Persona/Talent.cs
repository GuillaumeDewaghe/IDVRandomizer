using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDVRandomizer.Persona
{
    /// <summary>
    /// Talent from the persona web
    /// </summary>
    public class Talent
    {
        /// <summary>
        /// Name of the talent
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Occurence of the talent
        /// </summary>
        public Occurence Occurence { get; set; }
        /// <summary>
        /// Neighbours of the talent
        /// </summary>
        public Neighbours Neighbours { get; set; }

        public Talent()
        {

        }

        /// <summary>
        /// Creates a talent with a name and an occurence
        /// </summary>
        /// <param name="name"> Name of the talent </param>
        /// <param name="occurence"> Occurence of the talent </param>
        public Talent(string name, Occurence occurence)
        {
            Name = name;
            Occurence = occurence;
            Neighbours = new Neighbours();
        }

        public override String ToString()
        {
            return "Talent { Name = " + Name + ", " + Occurence + ", " + Neighbours + " }";
        }      
    }
}
