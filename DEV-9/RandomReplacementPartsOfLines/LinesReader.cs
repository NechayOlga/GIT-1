using System;
using System.IO;

namespace RandomReplacementPartsOfLines
{
    /// <summary>
    /// class LinesReader was created
    /// to read lines from text file
    /// </summary>
    class LinesReader
    {
        /// <summary>
        /// Method ReadLines reads 
        /// initial and replaving lines
        /// from text file
        /// </summary>
        /// <param ="currentLine"> parameter, in which contains the value of current string</param>
        /// <param name="initialLine">the line, which contains the subline, which will be replaced</param> 
        /// <param name="replacingLine">the line, which contains the replacing subline</param> 
        public void ReadLines(string currentLine, out string initialLine, out string replacingLine)
        {
            using (StreamReader streamReader = new StreamReader(currentLine))
            {
                if(currentLine == null)
                {
                    throw new FileNotFoundException();
                }
                initialLine = streamReader.ReadLine();
                replacingLine = streamReader.ReadLine();
                if ((initialLine == string.Empty)||(replacingLine == null))
                {
                    throw new ArgumentNullException();
                }                
            }
        }
    }
}
