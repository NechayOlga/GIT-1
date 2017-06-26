
namespace NondecreasingSequence
{
    class SequenceCheck
    {
        public bool Check(int[] SequenceArray)
        {
            for (int i = 1; i < SequenceArray.Length; i++)
            {
                if (SequenceArray[i] < SequenceArray[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
