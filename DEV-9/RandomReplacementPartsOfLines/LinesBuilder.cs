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

        //Method builds the replaced subline - subline, which will be replaced
        public string BuildReplacedSubline()
        {
            int beginningOfReplacedSubline = randomNumberBuilder.BuildBeginningOfReplacedSubline(InitialLine);
            int lengthOfReplacedSubline = randomNumberBuilder.BuildLengthOfReplacedSubline(InitialLine, beginningOfReplacedSubline);
            string replacedSubline = InitialLine.Substring(beginningOfReplacedSubline, lengthOfReplacedSubline);
            return replacedSubline;
        }

        //Method builds the replacing subline - subline, on which will be changed replaced subline
        public string BuildReplacingSubline()
        {
            int beginningOfReplacingSubline = randomNumberBuilder.BuildBeginningOfReplacingSubline(ReplacingLine);
            int lengthOfReplacingSubline = randomNumberBuilder.BuildLengthOfReplacingSubline(ReplacingLine, beginningOfReplacingSubline);
            string replacingSubline = ReplacingLine.Substring(beginningOfReplacingSubline, lengthOfReplacingSubline);
            return replacingSubline;
        }

        //Method replaces sublines
        public string SublinesReplacing(string initialLine, string replacedSubline, string replacingSubline)
        {
            string resultLine = Regex.Replace(initialLine, replacedSubline, replacingSubline);
            return resultLine;
        }
    }
}
