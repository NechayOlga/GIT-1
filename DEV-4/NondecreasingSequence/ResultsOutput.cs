using System;

namespace NondecreasingSequence
{
    class ResultsOutput
    {
        const string DECREASING = "\nNO, your sequence is decreasing";
        const string NONDECREASING = "\nYes, your sequence is nondecreasing";       
        public void Output (bool checker)
        {       
            Console.WriteLine(checker == false ? DECREASING : NONDECREASING);
        }
    }
}
