using System;
using System.Collections.Generic;
using System.Linq;

namespace Binary_list_MinNumber_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var binaryList = new List<int>()
            {
                0,0,1,0,0,0,0
            };
            
            Console.WriteLine("It took " + TimeTookToSort(binaryList) + " attempts to sort the binary list");
        }

        private static int TimeTookToSort(List<int> binaryList)
        {
            if(binaryList.Count() == 0)
            {
                return 0;
            }

            int numberOfZeroMove =0,
                numberOfZero = 0,
                numberOfOneMoves=0,
                numberOfOnes = 0;

            int count = 0;

            foreach(int num in binaryList) { 
                if(num == 0)
                {
                    numberOfZeroMove += count - numberOfZero++;
                }
                else
                {
                    numberOfOneMoves += count - numberOfOnes++;
                }
                count++;
            }

            return (numberOfZeroMove < numberOfOneMoves) ? numberOfOneMoves : numberOfOneMoves;
        }
    }
}
