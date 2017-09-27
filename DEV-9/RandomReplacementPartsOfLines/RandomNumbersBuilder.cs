using System;

namespace RandomReplacementPartsOfLines
{
    class RandomNumbersBuilder
    {
        Random randomNumber = new Random();

        // Method returns the index of beginning
        // of the replaced subline.
        // Parameter 0 in method Next() means the first
        // possible value of index.
        public int BuildBeginningOfReplacedSubline(string initialLine)
        {
            int indexOfBeginningOfReplacedSubline = randomNumber.Next(0, initialLine.Length);
            return indexOfBeginningOfReplacedSubline;
        }

        // Method returns the length
        // of the replaced subline.
        // Parameter 1 in method Next() means the minimal
        // possible value of the length.       
        public int BuildLengthOfReplacedSubline(string initialLine, int beginningOfReplacedSubline)
        {
            int lengthOfBeginningOfReplacedSubline = randomNumber.Next(1, initialLine.Length - beginningOfReplacedSubline);
            return lengthOfBeginningOfReplacedSubline;
        }

        // Method returns the index of beginning
        // of the replacing subline.
        // Parameter 0 in method Next() means the first
        // possible value of index.
        public int BuildBeginningOfReplacingSubline(string replacingLine)
        {
            int indexOfBeginningOfReplacingSubline = randomNumber.Next(0, replacingLine.Length);
            return indexOfBeginningOfReplacingSubline;
        }

        // Method returns the length
        // of the replacing subline.
        // Parameter 1 in method Next() means the minimal
        // possible value of the length. 
        public int BuildLengthOfReplacingSubline(string replacingLine, int beginningOfReplacingSubline)
        {
            int lengthOfBeginningOfReplacingSubline = randomNumber.Next(1, replacingLine.Length - beginningOfReplacingSubline);
            return lengthOfBeginningOfReplacingSubline;
        }
    }
}
