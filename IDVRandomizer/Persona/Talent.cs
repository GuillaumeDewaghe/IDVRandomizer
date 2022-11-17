namespace IDVRandomizer.Persona
{
    /// <summary>
    /// Talent from the persona web
    /// </summary>
    public class Talent
    {
        #region Parameters

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

        #endregion

        #region Constructors

        public Talent(string name, Maximum max, string parent)
        {
            Name = name;
            Occurence = new(max);
            Neighbourhood = new(parent);
        }

        public Talent(string name, Maximum max, List<string> children)
        {
            Name = name;
            Occurence = new(max);
            Neighbourhood = new(children);
        }

        public Talent(string name, Occurence occurence, Neighbourhood neighbourhood) 
        {
            Name = name;
            Occurence = occurence;
            Neighbourhood = neighbourhood;
        }

        public Talent(string name, Maximum max, string parent, List<string> children) 
        {
            Name = name;
            Occurence = new(max);
            Neighbourhood = new(parent, children);
        }

        #endregion

        public override String ToString()
        {
            return "Talent { Name = " + Name + ", " + Occurence + ", " + Neighbourhood + " }";
        }      
    }
}
