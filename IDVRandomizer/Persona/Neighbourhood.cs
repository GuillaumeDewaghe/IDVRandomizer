namespace IDVRandomizer.Persona
{
    /// <summary>
    /// Neighbourhood of a talent
    /// </summary>
    public class Neighbourhood
    {
        #region Parameters

        /// <summary>
        /// Previous talent
        /// </summary>
        public string Parent { get; set; }
        /// <summary>
        /// Next talents
        /// </summary>
        public List<string> Children { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a neighbourhood with a parent
        /// </summary>
        /// <param name="parent"></param>
        public Neighbourhood(string parent)
        {
            Parent = parent;
            Children = new List<string>();
        }

        /// <summary>
        /// Creates a neighbourhood with children
        /// </summary>
        /// <param name="children"></param>
        public Neighbourhood(List<string> children)
        {
            Parent = "";
            Children = children;
        }

        /// <summary>
        /// Creates a neighbourhood with parent and children
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="children"></param>
        public Neighbourhood(string parent, List<string> children)
        {
            Parent = parent;
            Children = children;
        }

        #endregion

        public override string ToString()
        {
            string neighbourhoodtoString = "Neighbourhood { ";
            string parentToString = "Parent = " + Parent;
            string childrenToString = "Children = " + String.Join(", ", Children);
            if (Parent.Equals(""))
            {
                neighbourhoodtoString += childrenToString + " }";
            } 
            else if(Children.Count == 0)
            {
                neighbourhoodtoString += parentToString + " }";
            }
            else
            {
                neighbourhoodtoString += parentToString + ", " + childrenToString + " }";
            }
            return neighbourhoodtoString;
        }
    }
}
