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
        public int BuildBeginningOfSubline(string line)
        {
            int indexOfBeginningOfReplacedSubline = randomNumber.Next(0, line.Length);
            return indexOfBeginningOfReplacedSubline;
        }

        // Method returns the length
        // of the replaced subline.
        // Parameter 1 in method Next() means the minimal
        // possible value of the length.       
        public int BuildLengthOfSubline(string line, int beginningOfSubline)
        {
            int lengthOfBeginningOfReplacedSubline = randomNumber.Next(1, line.Length - beginningOfSubline);
            return lengthOfBeginningOfReplacedSubline;
        }      
    }
}
