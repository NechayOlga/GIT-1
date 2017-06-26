using System;

namespace NondecreasingSequence
{
    class InputSequence
    {
        const string SHORTSEQUENCE = "One number isn't a sequense. Try again";
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