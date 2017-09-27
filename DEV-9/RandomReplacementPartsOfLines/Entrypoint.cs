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

            SublinesBuilder sublinesBuilder = new SublinesBuilder(initialLine, replacingLine);
            string replacedSubline = sublinesBuilder.BuildReplacedSubline();
            string replacingSubline = sublinesBuilder.BuildReplacingSubline();

            SublinesReplacer sublinesReplacer = new SublinesReplacer();
            string resultLine = sublinesReplacer.SublinesReplacing(initialLine, replacedSubline, replacingSubline);

            Outputer outputer = new Outputer();
            outputer.OutputOfLines(initialLine);
            outputer.OutputOfLines(replacingLine);
            outputer.OutputOfLines(resultLine);
            Console.ReadKey();                        
        }
    }
}
