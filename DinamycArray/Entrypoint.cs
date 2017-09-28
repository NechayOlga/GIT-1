using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamycArray
{
    class Entrypoint
    {
        static void Main(string[] args)
        {
            const string REPEAT_INPUT = "Enter only numbers.Try again.";
            const string INVALID_INDEX = "Invalid index. Try again";
            bool continueProgram = true;
            while (continueProgram)
            {
                try
                {
                    const string INPUT_ARRAY = "Enter array: ";
                    const string INPUT_INDEX_ADD = "Enter index to add: ";
                    //const string INPUT_INDEX_DEL = "Enter index to delete: ";
                    const string INPUT_NUMBER_ADD = "Enter number to add: ";
                    const string INPUT_NUMBER_DEL = "Enter number to delete: ";
                    const string CONTINUE_OR_EXIT = "\nEnter OK to continue, another key to exit";      
                    Console.WriteLine(INPUT_ARRAY);
                    Inputer inputer = new Inputer();
                    int[] FunnyArray = inputer.NumbersArray();
                    int count = FunnyArray.Length;
                    int length = FunnyArray.Length;
                    Outputer outputer = new Outputer();
                    Array array = new Array(FunnyArray, count);
                    bool check = true;
                    while(check)
                    {
                        if (count == length)
                        {
                            Console.WriteLine(INPUT_NUMBER_ADD);
                            int number = inputer.InputNumber();
                            Console.WriteLine(INPUT_INDEX_ADD);
                            int indexAdd = inputer.InputNumber();
                            array.AddWithIncrease(number, indexAdd);
                            FunnyArray = array.NumbersArray;
                            count = FunnyArray.Length;
                            length = FunnyArray.Length;
                            outputer.Output(array.NumbersArray);
                            count++;
                        }
                        else
                        {
                            Console.WriteLine(INPUT_NUMBER_DEL);
                            int number = inputer.InputNumber();
                            Console.WriteLine(INPUT_INDEX_ADD);
                            int indexAdd = inputer.InputNumber();
                            array.Add(number, indexAdd);
                            outputer.Output(array.NumbersArray);
                            count++;
                        }
                        /*Console.WriteLine();
                        Console.WriteLine(INPUT_INDEX_DEL);
                        int indexDel = inputer.InputNumber();
                        array.Delete(indexDel);
                        count--;
                        outputer.Output(array.NumbersArray);
                        Console.WriteLine(CONTINUE_OR_EXIT);*/
                        if (Console.ReadLine().Equals("J"))
                        {
                            continue;
                        }
                        Console.ReadKey();
                    }
                    Console.WriteLine(CONTINUE_OR_EXIT);
                    if (Console.ReadLine().Equals("OK"))
                    {
                        continue;
                    }
                }                   
                catch (FormatException)
                {
                    Console.WriteLine(REPEAT_INPUT);
                    Console.ReadKey();
                    continue;
                }
                catch(Exception)
                {
                    Console.WriteLine(INVALID_INDEX);
                    Console.ReadKey();
                    continue;
                }
                continueProgram = false;
            }
        }
    }
}
