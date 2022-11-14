namespace IDVRandomizer.Persona
{
    /// <summary>
    /// Branch which contains talents of the persona web
    /// </summary>
    public class Branch
    {
        /// <summary>
        /// Talents of the branch
        /// </summary>
        public List<Talent> Talents;

        public Branch()
        {
            Talents = new List<Talent>();
        }

        public Branch(List<Talent> talents)
        {
            Talents = talents;
        }

        public override string ToString()
        {
            return "Branch { " + String.Join(", ", Talents) + " }";
        }
    }
}
