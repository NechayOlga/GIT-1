using System;

namespace NondecreasingSequence
{
    class Entrypiont
    {
        const string ENTERSEQUENCE = "Enter sequence: ";
        const string FORMATEXCEPTION = "Enter only integer numbers. Please, try again";
        const string CONTINUE_OR_EXIT = "Press NEXT to continue, press ENTER and another key to exit";
        static void Main(string[] args)
        {
            bool continueInput = true;
            while (continueInput)
            {
                try
                {
                    Console.WriteLine(ENTERSEQUENCE);
                    InputSequence inputsequence = new InputSequence();
                    int[] SequenceArray = inputsequence.Input();
                    SequenceCheck sequencecheck = new SequenceCheck();
                    bool check = sequencecheck.Check(SequenceArray);
                    ResultsOutput resultsoutput = new ResultsOutput();
                    resultsoutput.Output(check);
                    Console.WriteLine(CONTINUE_OR_EXIT);
                    if (Console.ReadLine().Equals("NEXT"))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ReadKey();
                    }
                }                
                catch (FormatException)
                {
                    Console.WriteLine(FORMATEXCEPTION);
                    continue;
                }
                continueInput = false;
            }
        }
    }
}