using System;

namespace NondecreasingSequence
{
    class InputSequence
    {
        const string ENTER_SEQUENCE = "Enter sequence: ";
        public int[] Input(string[] args)
        {
            int[] SequenceArray = null;
            if (args.Length == 0)
            {
                Console.WriteLine(ENTER_SEQUENCE);
                string[] Sequence = Console.ReadLine().Split();
                SequenceArray = new int[Sequence.Length];
                for (int i = 0; i < Sequence.Length; i++)
                {
                    SequenceArray[i] = int.Parse(Sequence[i]);
                }
            }
            else
            {
                SequenceArray = new int[args.Length];
                for (int i = 0; i < args.Length; i++)
                {
                    SequenceArray[i] = int.Parse(args[i]);
                }

            }
            return SequenceArray;
        }
    }
}
