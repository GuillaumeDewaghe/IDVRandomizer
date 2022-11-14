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
        /// Neighbourhood of the talent
        /// </summary>
        public Neighbourhood Neighbourhood { get; set; }

        /// <summary>
        /// Creates a talent with a name and an occurence
        /// </summary>
        /// <param name="name"> Name of the talent </param>
        /// <param name="occurence"> Occurence of the talent </param>
        public Talent(string name, Occurence occurence)
        {
            Name = name;
            Occurence = occurence;
            Neighbourhood = new Neighbourhood();
        }

        public override String ToString()
        {
            return "Talent { Name = " + Name + ", " + Occurence + ", " + Neighbourhood + " }";
        }      
    }
}
