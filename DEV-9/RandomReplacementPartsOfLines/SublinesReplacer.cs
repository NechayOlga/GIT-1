using System.Text.RegularExpressions;

namespace RandomReplacementPartsOfLines
{
    class SublinesReplacer
    {
        public string SublinesReplacing(string initialLine, string replacedSubline, string replacingSubline)
        {
            string resultLine = Regex.Replace(initialLine, replacedSubline, replacingSubline);
            return resultLine;
        }
    }
}
