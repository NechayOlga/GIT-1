using System;
using System.IO;

namespace RandomReplacementPartsOfLines
{
    class Entrypoint
    {
        static void Main(string[] args)
        {
            try
            {
                //Creating initial and replacing lines
                string line = @"e:\TAT\GIT-1\DEV-9\RandomReplacementPartsOfLines\Lines.txt";
                LinesReader linesReader = new LinesReader();
                string initialLine = string.Empty;
                string replacingLine = string.Empty;
                linesReader.ReaderOfLines(line, out initialLine, out replacingLine);

                //Creating of replaced and replacing sublines
                LinesBuilder sublinesBuilder = new LinesBuilder(initialLine, replacingLine);
                string replacedSubline = sublinesBuilder.BuildReplacedSubline();
                string replacingSubline = sublinesBuilder.BuildReplacingSubline();

                //Creating of result line with replacing parts
                string resultLine = sublinesBuilder.SublinesReplacing(initialLine, replacedSubline, replacingSubline);

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
