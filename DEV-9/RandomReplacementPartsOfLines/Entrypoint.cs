using System;
using System.IO;

namespace RandomReplacementPartsOfLines
{
    /// <summary>
    /// Class contains entrypoint of programm
    /// </summary>
    class Entrypoint
    {
        /// <summary>
        /// Method creats the object of LinesReader type
        /// and calls the method of reading lines from text file.
        /// Then object of the type LinesBuilder is created,
        /// method to creating of replaced and replacing sublines takes place.
        /// Method to replace sublines is called.
        /// Initial, replacing and result lines outputs.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                //Creating initial and replacing lines
                string line = @"e:\TAT\GIT-1\DEV-9\RandomReplacementPartsOfLines\Lines.txt";
                LinesReader linesReader = new LinesReader();
                linesReader.ReadLines(line, out string initialLine, out string replacingLine);

                //Creating of replaced and replacing sublines
                LinesBuilder sublinesBuilder = new LinesBuilder(initialLine, replacingLine);
                string replacedSubline = sublinesBuilder.BuildReplacedSubline();
                string replacingSubline = sublinesBuilder.BuildReplacingSubline();

                //Creating of result line with replacing parts
                string resultLine = sublinesBuilder.ReplaceSublines(initialLine, replacedSubline, replacingSubline);

                //Outputing of initial, replacing and result lines
                Console.WriteLine(initialLine);
                Console.WriteLine(replacingLine);
                Console.WriteLine(resultLine);
                Console.ReadKey();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Text file is not found. Check text file.");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("The line in text file is absent. Add the line to text file.");
            }
            Console.ReadKey();
        }
    }
}
