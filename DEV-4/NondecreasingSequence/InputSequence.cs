using System;

namespace NondecreasingSequence
{
    class InputSequence
    {
        string[] Sequence = Console.ReadLine().Split();
        public int[] Input ()
        {
            int[] SequenceArray = new int[Sequence.Length];           
            for (int i = 0; i < Sequence.Length; i++)
            {
                SequenceArray[i] = int.Parse(Sequence[i]);
            }
            return SequenceArray;
        }
    }
}