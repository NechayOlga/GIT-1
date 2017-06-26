using System;

namespace NondecreasingSequence
{
    class Entrypiont
    {
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter sequence: ");
                    InputSequence inputsequence = new InputSequence();
                    int[] SequenceArray = inputsequence.Input();
                    SequenceCheck sequencecheck = new SequenceCheck();
                    int check = sequencecheck.Check(SequenceArray);
                    ResultsOutput resultsoutput = new ResultsOutput();
                    resultsoutput.Output(check);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only integer numbers. Please, try again. To continue press next, to exit no");
                    if (Console.ReadLine().Equals("next"))
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }
        }
    }
}