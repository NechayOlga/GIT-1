namespace NondecreasingSequence
{
    class SequenceChecker
    {
        public bool Checker(int[] sequenceArray)
        {
            for (int i = 1; i < sequenceArray.Length; i++)
            {
                if (sequenceArray[i] < sequenceArray[i - 1])
                {
                    return false;
                }             
            }
            return true;
        }
    }
}
