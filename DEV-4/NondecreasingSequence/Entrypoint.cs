using System;

namespace NondecreasingSequence
{
    class Entrypiont
    {
        const string FORMAT_EXCEPTION = "Enter only integer numbers. Please, try again";
        const string CONTINUE_OR_EXIT = "Press NEXT to continue, press ENTER and another key to exit";
        const string SHORTSEQUENCE = "One number isn't a sequense. Try again";
        static void Main(string[] args)
        {
            bool continueInput = true;
            while (continueInput)
            {
                try
                {                   
                    InputSequence inputSequence = new InputSequence();
                    int[] sequenceArray = inputSequence.Input(args);
                    if (sequenceArray.Length == 1)
                    {
                        Console.WriteLine(SHORTSEQUENCE);
                        continue;
                    }
                    SequenceChecker sequenceCheck = new SequenceChecker();
                    bool checker = sequenceCheck.Checker(sequenceArray);
                    ResultsOutput resultsOutput = new ResultsOutput();
                    resultsOutput.Output(checker);
                    Console.WriteLine(CONTINUE_OR_EXIT);
                    if (Console.ReadLine().Equals("NEXT"))
                    {
                        continue;
                    }
                    Console.WriteLine();
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    Console.WriteLine(FORMAT_EXCEPTION);
                    continue;
                }
                continueInput = false;
            }
        }
    }
}