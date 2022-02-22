using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int searchNum = Convert.ToInt32(Console.ReadLine());
                int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int firstInd = 0;
                int lastInd = arr.Length;

                while (firstInd < (lastInd-1))
                {
                    if (searchNum == arr[0])
                    {
                        Console.WriteLine($"Искомое число: {arr[0]}");
                        break;
                    } 
                    
                    int middleInd = (firstInd + lastInd) / 2;
                    int value = arr[middleInd];
                    if (value == searchNum)
                    {
                        Console.WriteLine($"Искомое число: {value}");
                        break;
                    }
                    else if (value > searchNum)
                        lastInd = middleInd;
                    else
                        firstInd = middleInd;
                }

                while (firstInd == (lastInd - 1))
                {
                    int middleInd = (firstInd + lastInd) / 2;
                    int value = arr[middleInd - 1];
                    if (value == searchNum)
                    {
                        Console.WriteLine($"Искомое число: {value}");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Искомое число отсутствует в массиве.");
                        break;

                    }
                }

            }
            
            
                


        }
    }
}
