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
                LinesBuilder replacedSublineAndResultLineBuilder = new LinesBuilder(initialLine);

                Random randomNumber = new Random(); 

                int beginningOfReplacedSubline = randomNumber.Next(0, initialLine.Length);
                int lengthOfReplacedSubline = randomNumber.Next(1,initialLine.Length - beginningOfReplacedSubline);
                string replacedSubline = replacedSublineAndResultLineBuilder.BuildSubline(beginningOfReplacedSubline, lengthOfReplacedSubline);

                LinesBuilder replacingSublineBuilder = new LinesBuilder(replacingLine);
                int beginningOfReplacingSubline = randomNumber.Next(0, replacingLine.Length);
                int lengthOfReplacingSubline = randomNumber.Next(1, replacingLine.Length - beginningOfReplacingSubline);
                string replacingSubline = replacingSublineBuilder.BuildSubline(beginningOfReplacingSubline, lengthOfReplacingSubline);

                //Creating of result line with replacing parts
                string resultLine = replacedSublineAndResultLineBuilder.ReplaceSublines(initialLine, replacedSubline, replacingSubline);

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
