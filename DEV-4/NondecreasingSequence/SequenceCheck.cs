using System;

namespace NondecreasingSequence
{
    class SequenceCheck
    {
        public int Check(int[] SequenceArray)
        {
            int check = 0;
            for (int i = 1; i < SequenceArray.Length; i++)
            {
                if (SequenceArray[i] >= SequenceArray[i - 1])
                {
                    check++;
                }
            }
            return check;
        }
    }
}
