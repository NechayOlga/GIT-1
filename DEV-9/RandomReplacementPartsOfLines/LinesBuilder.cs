using System.Text.RegularExpressions;

namespace RandomReplacementPartsOfLines
{
    class LinesBuilder
    {
        /// <summary>
        /// Class was created for
        /// building sublines
        /// </summary>
        public string InitialLine
        { get; private set; }
        public LinesBuilder(string initialLine)
        {
            InitialLine = initialLine;
        }
      
        //RandomNumbersBuilder randomNumberBuilder = new RandomNumbersBuilder();
        /// <summary>
        /// Method builds  sublines
        /// </summary>
        /// <returns>string replacedSubline</returns>
        public string BuildSubline(int beginningOfSubline, int lengthOfSubline)
        {        
            string subline = InitialLine.Substring(beginningOfSubline, lengthOfSubline);
            return subline;           
        }
        
        /// <summary>
        /// Method replaces sublines
        /// </summary>
        /// <param name="initialLine">the line, which contains the subline, which will be replaced</param>
        /// <param name="replacedSubline">the subline, that will be replaced</param>
        /// <param name="replacingSubline">the subline, on which will be replaced replacedSubline</param>
        /// <returns>string resultLine</returns>
        public string ReplaceSublines(string initialLine, string replacedSubline, string replacingSubline)
        {
            string resultLine = Regex.Replace(initialLine, replacedSubline, replacingSubline);
            return resultLine;
        }
    }
}
