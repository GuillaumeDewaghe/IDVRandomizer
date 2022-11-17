namespace IDVRandomizer.Persona
{
    /// <summary>
    /// Location of the branch in the persona web
    /// </summary>
    public enum Section
    {
        East = 3,
        South = 6,
        West = 9,
        North = 12
    }

    /// <summary>
    /// Branch which contains talents of the persona web
    /// </summary>
    public class Branch
    {
        #region Parameters

        /// <summary>
        /// Location of the branch
        /// </summary>
        public Section Section { get; set; }
        /// <summary>
        /// Talents of the branch
        /// </summary>
        public List<Talent> Talents { get; set; }

        #endregion

        /// <summary>
        /// Creates a branch with a section and a list of talents
        /// </summary>
        /// <param name="section"></param>
        /// <param name="talents"></param>
        public Branch(Section section, List<Talent> talents)
        {            
            Section = section;
            Talents = talents;
        }

        public override string ToString()
        {
            return "Branch { Section = " + Section + ", " + String.Join(", ", Talents) + " }";
        }
    }
}
