namespace IDVRandomizer.Persona
{
    /// <summary>
    /// Persona web of a character
    /// </summary>
    public class Persona
    {
        #region Parameters

        /// <summary>
        /// Amount of points available for the persona web
        /// </summary>
        public int Points { get; set; } = 130;
        /// <summary>
        /// Branches of the persona web
        /// </summary>
        public List<Branch> Branches { get; set; }

        #endregion

        public Persona(List<Branch> branches)
        {
            Branches = branches;
        }

        public override string ToString()
        {
            return "Persona = { " + String.Join(", ", Branches) + " }";
        }
    }
}
