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

            LinesBuilder sublinesBuilder = new LinesBuilder(initialLine, replacingLine);
            string replacedSubline = sublinesBuilder.BuildReplacedSubline();
            string replacingSubline = sublinesBuilder.BuildReplacingSubline();

            string resultLine = sublinesBuilder.SublinesReplacing(initialLine, replacedSubline, replacingSubline);

            Console.WriteLine(initialLine);
            Console.WriteLine(replacingLine);
            Console.WriteLine(resultLine);
            Console.ReadKey();                        
        }
    }
}
