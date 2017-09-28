using System;

namespace RandomReplacementPartsOfLines
{
    class Entrypoint
    {
        static void Main(string[] args)
        {
            const string INITIAL_LINE = "abcdef";
            const string REPLACING_LINE = "efghij";
            
            string initialLine = INITIAL_LINE;
            string replacingLine = REPLACING_LINE;

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
    }
}
