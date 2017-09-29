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
                if(line == null)
                {
                    throw new FileNotFoundException();
                }
                initialLine = streamReader.ReadLine();
                replacingLine = streamReader.ReadLine();
                if ((initialLine == null)||(replacingLine == null))
                {
                    throw new ArgumentNullException();
                }                
            }
        }
    }
}
