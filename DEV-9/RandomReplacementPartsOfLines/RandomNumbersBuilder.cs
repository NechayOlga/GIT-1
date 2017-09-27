using System;

namespace RandomReplacementPartsOfLines
{
    class RandomNumbersBuilder
    {
        Random randomNumber = new Random();

        public int BuildBeginningOfReplacedSubline(string initialLine)
        {
            return randomNumber.Next(0, initialLine.Length);
        }
        public int BuildLengthOfReplacedSubline(string initialLine, int beginningOfReplacedSubline)
        {
            return randomNumber.Next(1, initialLine.Length - beginningOfReplacedSubline);
        }
        public int BuildBeginningOfReplacingSubline(string replacingLine)
        {
            return randomNumber.Next(0, replacingLine.Length);
        }
        public int BuildLengthOfReplacingSubline(string replacingLine, int beginningOfReplacingSubline)
        {
            return randomNumber.Next(1, replacingLine.Length - beginningOfReplacingSubline);
        }
    }
}
