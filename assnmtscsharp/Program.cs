using System;
using System.Linq;

public class Exercise2
{
    public static void Main()
    {
        int[] ar = new int[100];
         Console.Write("enter number of elements");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter numbers");
        for (int i = 0; i < n; i++)
        {
            ar[i] = Convert.ToInt32(Console.ReadLine());

        }
            int maxValue = ar.Max();

            Console.Write("greatest number is {0}",  maxValue);
                   

                Console.ReadKey();
   
        }


    }
