using System;
using  System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       //Compute the sum, or total, of the numbers in the list.
       //Compute the average of the numbers in the list.
       //Find the maximum, or largest, number in the list.

        List<int>numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
 
        int number = -1;
        // ask the user to enter the numbers
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        // checking whether the user entered any number.
        if (numbers.Count > 0)
        {
            int sum = 0;

            foreach(int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"The sum is {sum}: ");

            // calculate the average
            double average = (double)sum / numbers.Count;

            Console.WriteLine($"The average is {average}: ");

            // find the largest number
            int largest = numbers[0];

            foreach(int num in numbers)
            {
                if(num > largest)
                {
                    largest = num;
                }
            }
            Console.WriteLine($"The largest number {largest}");
            int smallestPositive = int .MaxValue;

            foreach (int num in numbers)
            {
                if (num > 0 && num < smallestPositive)
                {
                    smallestPositive = num;
                    
                }  
            }
            if (smallestPositive != int.MaxValue)
            {
                Console.WriteLine($"The smallest positive number is:{smallestPositive}");
            }
            else
            {
                Console.WriteLine("No positive numbers were entered. ");
            }
        } 
        else
        {
            Console.WriteLine("No number were entered.");
        }
    }
}