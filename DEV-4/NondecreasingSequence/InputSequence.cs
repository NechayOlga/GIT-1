using System;

namespace NondecreasingSequence
{
    class InputSequence
    {
        const string ENTER_SEQUENCE = "Enter sequence: ";
        public int[] Input(string[] commandPromptInput)
        {
            int[] InputSequenceArray = null;
            if (commandPromptInput.Length == 0)
            {
                Console.WriteLine(ENTER_SEQUENCE);
                string[] Sequence = Console.ReadLine().Split();
                InputSequenceArray = new int[Sequence.Length];
                for (int i = 0; i < Sequence.Length; i++)
                {
                    InputSequenceArray[i] = int.Parse(Sequence[i]);
                }
            }
            else
            {
                InputSequenceArray = new int[commandPromptInput.Length];
                for (int i = 0; i < commandPromptInput.Length; i++)
                {
                    InputSequenceArray[i] = int.Parse(commandPromptInput[i]);
                }

            }
            return InputSequenceArray;
        }
    }
}