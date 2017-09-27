namespace RandomReplacementPartsOfLines
{
    class SublinesBuilder
    {
        public string InitialLine
        { get; private set; }
        public string ReplacingLine
        { get; private set; }
        public SublinesBuilder(string initialLine, string replacingLine)
        {
            InitialLine = initialLine;
            ReplacingLine = replacingLine;
        }

        RandomNumbersBuilder randomNumberBuilder = new RandomNumbersBuilder();
        public string BuildReplacedSubline()
        {
            int beginningOfReplacedSubline = randomNumberBuilder.BuildBeginningOfReplacedSubline(InitialLine);
            int lengthOfReplacedSubline = randomNumberBuilder.BuildLengthOfReplacedSubline(InitialLine, beginningOfReplacedSubline);
            string replacedSubline = InitialLine.Substring(beginningOfReplacedSubline, lengthOfReplacedSubline);
            return replacedSubline;
        }
        public string BuildReplacingSubline()
        {
            int beginningOfReplacingSubline = randomNumberBuilder.BuildBeginningOfReplacingSubline(ReplacingLine);
            int lengthOfReplacingSubline = randomNumberBuilder.BuildLengthOfReplacingSubline(ReplacingLine, beginningOfReplacingSubline);
            string replacingSubline = ReplacingLine.Substring(beginningOfReplacingSubline, lengthOfReplacingSubline);
            return replacingSubline;
        }     
    }
}
