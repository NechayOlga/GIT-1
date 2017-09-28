using System;
using System.IO;

namespace RandomReplacementPartsOfLines
{
    class LinesReader
    {
        public void ReaderOfLines(string line, out string initialLine, out string replacingLine)
        {
            using (StreamReader streamReader = new StreamReader(line))
            {
                initialLine = streamReader.ReadLine();
                replacingLine = streamReader.ReadLine();
            }
        }

        /*public string ReaderReplacingLine(string line)
        {
            string replacingLine = String.Empty;
            using (StreamReader streamReader = new StreamReader(line))
            {
                
            }
            return replacingLine;
        }*/

    }
}
