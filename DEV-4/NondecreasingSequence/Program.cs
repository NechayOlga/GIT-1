using System;

namespace NondecreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter size: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] SequenceArray = new int[size];
                    string Sequence;
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine("Enter a[" + (i + 1) + "] element");
                        Sequence = Console.ReadLine();
                        SequenceArray[i] = int.Parse(Sequence);
                    }
                    Console.WriteLine("Sequence: ");
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write(SequenceArray[i] + " ");
                    }
                    int check = 0;
                    for (int i = 1; i < size; i++)
                    {
                        if (SequenceArray[i] >= SequenceArray[i - 1])
                        {
                            check++;
                        }
                    }
                    if (check == 0)
                    {
                        Console.WriteLine("\nNO, your sequence is decreasing");
                    }
                    else
                    {
                        Console.WriteLine("\nYes, your sequence is nondecreasing");
                    }
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a number. Please, try again");
                    continue;
                }
            }
        }
    }
}