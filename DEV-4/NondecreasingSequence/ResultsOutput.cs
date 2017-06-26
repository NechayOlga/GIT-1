using System;

namespace NondecreasingSequence
{
    class ResultsOutput
    {
        public void Output(int check)
        {
            if (check == 0)
            {
                Console.WriteLine("\nNO, your sequence is decreasing. Enter ");
            }
            else
            {
                Console.WriteLine("\nYes, your sequence is nondecreasing");
            }
            Console.ReadKey();
        }
    }
}
