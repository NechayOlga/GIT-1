using System;

namespace RandomReplacementPartsOfLines
{
    /// <summary>
    /// Class creats the random values
    /// for index and length of sublines
    /// </summary>
    class RandomNumbersBuilder
    {
        Random randomNumber = new Random();

        /// <summary>
        /// Method BuildBeginningOfSubline returns the index of subline.
        /// Parameter 0 in method Next() means the first
        /// possible value of index.
        /// </summary>
        /// <param name="line"> parametr, in which contains the value of current string</param>
        /// <returns>int index of subline</returns>
        public int BuildBeginningOfSubline(string line)
        {
            int indexOfBeginningOfSubline = randomNumber.Next(0, line.Length);
            return indexOfBeginningOfSubline;
        }

        /// <summary>
        /// Method BuildLengthOfSubline returns the length of subline.
        /// Parameter 0 in method Next() means the first
        /// possible value of index.
        /// </summary>
        /// <param name="line"> parametr, in which contains the value of current string</param>
        /// <returns>int length of subline</returns>       
        public int BuildLengthOfSubline(string line, int beginningOfSubline)
        {
            int lengthOfBeginningOfSubline = randomNumber.Next(1, line.Length - beginningOfSubline);
            return lengthOfBeginningOfSubline;
        }      
    }
}
