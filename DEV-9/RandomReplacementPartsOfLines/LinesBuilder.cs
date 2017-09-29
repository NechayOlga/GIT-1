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
        public string ReplacingLine
        { get; private set; }
        public LinesBuilder(string initialLine, string replacingLine)
        {
            InitialLine = initialLine;
            ReplacingLine = replacingLine;
        }
      
        RandomNumbersBuilder randomNumberBuilder = new RandomNumbersBuilder();
        /// <summary>
        /// Method builds the replaced subline - subline, which will be replaced
        /// </summary>
        /// <returns>string replacedSubline</returns>
        public string BuildReplacedSubline()
        {
            int beginningOfReplacedSubline = randomNumberBuilder.BuildBeginningOfSubline(InitialLine);
            int lengthOfReplacedSubline = randomNumberBuilder.BuildLengthOfSubline(InitialLine, beginningOfReplacedSubline);
            string replacedSubline = InitialLine.Substring(beginningOfReplacedSubline, lengthOfReplacedSubline);
            return replacedSubline;
        }
        /// <summary>
        /// Method builds the replacing subline - subline, on which will be changed replaced subline
        /// </summary>
        /// <returns>string replacingSubline</returns>
        public string BuildReplacingSubline()
        {
            int beginningOfReplacingSubline = randomNumberBuilder.BuildBeginningOfSubline(ReplacingLine);
            int lengthOfReplacingSubline = randomNumberBuilder.BuildLengthOfSubline(ReplacingLine, beginningOfReplacingSubline);
            string replacingSubline = ReplacingLine.Substring(beginningOfReplacingSubline, lengthOfReplacingSubline);
            return replacingSubline;
        }
        /// <summary>
        /// Method replaces sublines
        /// </summary>
        /// <param name="initialLine">the line, which contains the subline, which will be replaced</param>
        /// <param name="replacedSubline">the subline, that will be replaced</param>
        /// <param name="replacingSubline">the subline, on which will be replaced replacedSubline</param>
        /// <returns>string resultLine</returns>
        public string SublinesReplacing(string initialLine, string replacedSubline, string replacingSubline)
        {
            string resultLine = Regex.Replace(initialLine, replacedSubline, replacingSubline);
            return resultLine;
        }
    }
}
