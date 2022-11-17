namespace IDVRandomizer.Persona
{
    /// <summary>
    /// Number of points max possible for a talent
    /// </summary>
    public enum Maximum
    {
        One = 1,
        Three = 3
    }

    /// <summary>
    /// Occurence of a talent
    /// </summary>
    public class Occurence
    {
        #region Parameters

        /// <summary>
        /// Current number of points given to the talent
        /// </summary>
        public int Current { get; set; } = 0;
        /// <summary>
        /// Number max of points which can be given to the talent
        /// </summary>
        public Maximum Max { get; set; }

        #endregion

        /// <summary>
        /// Creates an occurence with a max
        /// </summary>
        /// <param name="max"> Max points </param>
        public Occurence(Maximum max)
        {
            Max = max;
        }

        public override string ToString()
        {
            return "Occurence { Current = " + Current + ", Max = " + (int) Max + " }";
        }
    }
}
