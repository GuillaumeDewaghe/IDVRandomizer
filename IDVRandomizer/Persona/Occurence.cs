namespace IDVRandomizer.Persona
{
    public enum Max
    {
        One = 1,
        Three = 3
    }

    /// <summary>
    /// Occurence of a talent
    /// </summary>
    public class Occurence
    {
        /// <summary>
        /// Current number of points given to the talent
        /// </summary>
        public int Current { get; set; }
        /// <summary>
        /// Number max of points which can be given to the talent
        /// </summary>
        public Max Max { get; set; }

        /// <summary>
        /// Creates an occurence with a max
        /// </summary>
        /// <param name="max"> Max points </param>
        public Occurence(Max max)
        {
            Current = 0;
            Max = max;
        }

        public override string ToString()
        {
            return "Occurence { Current = " + Current + ", Max = " + (int) Max + " }";
        }
    }
}
