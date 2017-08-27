using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Entrypoint
    {
        static void Main(string[] args)
        {
            //const string CONTINUE_INPUT = "\nEnter STOP to exit";
            const string CONTINUE_OR_EXIT = "\n1)To stop the program enter 'exit' and ENTER." +
                                            "\nTo create new product list enter 'new product list'";
            const string CONTINUE_COMMANDS ="\n2)To enter new commands press 'new command' " +
                                            "\nTo create new product list enter 'new product list'";
            const string FORMAT_EXCEPTION = "Invalid format of data, try again";
            string nextActivity = String.Empty;
            bool checkStop = true;
            while (checkStop == true)
            {
                try
                {
                    PurchaseBuilder purchaseBuilder = new PurchaseBuilder();
                    Outputer outputer = new Outputer();        
                    purchaseBuilder.BuildPurchase();
                    Inputer inputer = new Inputer();
                    bool mark = true;
                    while (mark)
                    {
                        try
                        {
                            outputer.OutputPurchase(purchaseBuilder);
                            outputer.OutputCommands();
                            string inputedCommand = inputer.InputStrings();
                            CommandsBuilder commandsBuilder = new CommandsBuilder();
                            string commandResult = commandsBuilder.BuildCommands(inputedCommand, purchaseBuilder.ArrayPurchaseBuild());
                            Console.Write(commandResult);
                            Console.WriteLine(CONTINUE_COMMANDS);
                            Console.WriteLine(CONTINUE_OR_EXIT);
                            nextActivity = Console.ReadLine();
                            if (nextActivity.Equals("new command"))
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch (NotExistentTypeAverageTypeCommandException typeMessage)
                        {
                            Console.WriteLine(typeMessage.Message);
                            continue;
                        }
                        catch (NotExistentCommandException commandMessage)
                        {
                            Console.WriteLine(commandMessage.Message);
                            continue;
                        }
                    }   
                }              
                catch (NegativeQuantityException quantityMessage)
                {
                    Console.WriteLine(quantityMessage.Message);
                    continue;
                }
                catch (NegativePriceException priceMessage)
                {
                    Console.WriteLine(priceMessage.Message);
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine(FORMAT_EXCEPTION);
                    continue;
                }
                if (nextActivity.Equals("exit"))
                {
                    break;
                }
                if(nextActivity.Equals("new product list"))
                {
                    continue;
                }
                checkStop = false;
                Console.ReadKey();      
            }
        }
    }
}
