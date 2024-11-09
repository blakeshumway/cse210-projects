using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>(); 

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        float number = 0;
        do
        {
            Console.Write($"Enter Number: ");

            string response = Console.ReadLine();
            number = float.Parse(response);


            if (number != 0)
            {
                numbers.Add(number); 
            }


        
        } while(number != 0);

        //get the total sum
        float totalSum = 0;
        foreach (float i in numbers)
        {
            totalSum += i;
        }

        //get the average
        float average = totalSum / numbers.Count;


        //get the largest number
        float largestNumber = 0;
        foreach (float i in numbers)
        {
            if(i > largestNumber)
            {
                largestNumber = i;
            }
        
        }
    
        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");


    }
}