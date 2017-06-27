﻿using System;

namespace NondecreasingSequence
{
    class Entrypiont
    {
        const string ENTER_SEQUENCE = "Enter sequence: ";
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
                    Console.WriteLine(ENTER_SEQUENCE);
                    InputSequence inputsequence = new InputSequence();
                    int[] SequenceArray = inputsequence.Input();
                    if (SequenceArray.Length == 1)
                    {
                        Console.WriteLine(SHORTSEQUENCE);
                        continue;
                    }
                    else
                    {
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