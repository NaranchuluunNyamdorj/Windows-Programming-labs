using System;
using Calcer;
namespace Laboratory_1{

    class Program{

        static void Main(string[] args){
            CalculatorBase calcer1 = new CalculatorBase();
            int x, y;
            calcer1.displayResult();

            while (true){
                Console.WriteLine("\n");
                Console.WriteLine("1. Add numbers, 2. Subtract numbers, 3. Display Memory, 4. Clear Memory, 5. Display result");
                Console.WriteLine("6. Clear Result, 7. Remove 1 number, 8. Increase Memory By index, 9. Decrease Memory By index");
                Console.WriteLine("10. Delete Memory By index, 11. Add Number To Memory 12. Exit");
                Console.WriteLine("\n");
                int command = Convert.ToInt32(Console.ReadLine());
                switch (command){
                    case 1:
                        Console.Write("Enter an adding number: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        calcer1.add(x);
                        Console.WriteLine("Added!");
                        calcer1.displayResult();
                        break;
                    case 2:
                        Console.Write("Enter a subtracting number: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        calcer1.subtract(x);
                        Console.WriteLine("Deducted!");
                        calcer1.displayResult();
                        break;
                    case 3:
                        calcer1.DisplayMemory();
                        break;
                    case 4:
                        calcer1.ClearMemory();
                        Console.WriteLine("Memory cleared!");
                        break;
                    case 5:
                        calcer1.displayResult();
                        break;
                    case 6:
                        calcer1.clearResult();
                        Console.WriteLine("Result cleared!");
                        break;
                    case 7:
                        calcer1.removeByOne();
                        calcer1.displayResult();
                        break;
                    case 8:
                        Console.Write("Enter an index number: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter a subtracting number: ");
                        y = Convert.ToInt32(Console.ReadLine());

                        calcer1.memoryList[x].DecreaseMemoryItem(y);
                        calcer1.DisplayCurrentMemoryItem(x);
                        break;
                    case 9:
                        Console.Write("Enter an index number: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter a adding number: ");
                        y = Convert.ToInt32(Console.ReadLine());

                        calcer1.memoryList[x].IncreaseMemoryItem(y);
                        calcer1.DisplayCurrentMemoryItem(x);
                        break;
                    case 10:
                        Console.Write("Enter an index number: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        calcer1.DeleteCurrentMemoryItem(x);
                        Console.WriteLine("Deleted!");
                        break;
                    case 11:
                        calcer1.addToMemory();
                        break;
                    case 12:
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Wrong command.");
                        break;
                }
            }
        }
    }
}