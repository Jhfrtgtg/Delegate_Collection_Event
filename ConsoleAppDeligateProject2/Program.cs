
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegateAssignment.DeligateAssignment2
{
    delegate int[] SortReverse(int[] num,int count);
    public class DeligateTwo
    {

        static void Main(string[] args)
        {
            DeligateTwo deligateTwo = new DeligateTwo();
            SortReverse SR = new SortReverse(deligateTwo.Sort);
            Console.WriteLine("Enter the array");
            int[] array = new int[100];
            int count = 0; int num;int[] array1 = new int[100];
            while (int.TryParse(Console.ReadLine(), out num))
            {
             array[count] = num;
             count++;
            }
            Console.WriteLine("Enter the choice 1 for sorting and 2 for reverse ");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
               array1 = SR(array,count);
            }
            else if (number == 2)
            {
                SR += new SortReverse(deligateTwo.Reverse);
                SR -= new SortReverse(deligateTwo.Sort);
                array1 = SR(array,count);
            }
            for(int j = 0; j < count; j++)
            {
                Console.WriteLine(array1[j]);
            }


        }
        public int[] Sort(int[] num,int count)
        {
            int temp;
            int[] sorted = num;
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count-1-i; j++)
                {
                    if (sorted[j] > sorted[j + 1])
                    {
                        temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }
            return sorted;
        }

        public int[] Reverse(int[] num,int count)
        {
            int[] reverse = new int[count];
            for (int i = 0; i < count; i++)
            {
                reverse[count - 1-i] = num[i];
            }
            return reverse;
        }

    }
}