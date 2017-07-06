namespace NondecreasingSequence
{
    class SequenceChecker
    {
        public bool Checker(int[] SequenceArrayChecker)
        {
            for (int i = 1; i < SequenceArrayChecker.Length; i++)
            {
                if (SequenceArrayChecker[i] < SequenceArrayChecker[i - 1])
                {
                    return false;
                }             
            }
            return true;
        }
    }
}
