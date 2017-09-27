using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    class Entrypoint
    {
        static void Main(string[] args)
        {
            const string FORMAT_EXCEPTION = "Invalid format. Try again.";
            const string CONTINUE_OR_EXIT = "To continue press Continue, to exit another key.";
            bool continueProgram = true;
            while (continueProgram)
            {
                Inputer inputer = new Inputer();
                Outputer outputer = new Outputer();
                int number_to_add = inputer.Input();
                LinkedList2 list2 = new LinkedList2(2);
                list2.Add(number_to_add);
                outputer.Output(list2);
                try
                {
                    int number_to_delete = inputer.Input();
                    list2.Delete(number_to_delete);
                    outputer.Output(list2);
                }
                catch (IndexOutOfRangeException messege)
                {
                    Console.WriteLine(messege);
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine(FORMAT_EXCEPTION);
                    continue;
                }
                Console.WriteLine(CONTINUE_OR_EXIT);
                if (Console.ReadLine().Equals("Continue"))
                {
                    continue;
                }
                continueProgram = false;
                Console.ReadKey();
            }       
        }
    }
}
