// Ryan Blumenhorst
// Prime Number Finder

using System;
using System.Linq;

public class PrimeNumberFinder
{
    public static void Main(string[] args)
    {
        try
        {
            //Prompt
            Console.WriteLine("Please enter a number:");
            //Read User Number
            int n = Convert.ToInt32(Console.ReadLine());
            //Count of how many factors the number has
            int count = 0;
            //Array to hold the factors
            int[] factors = new int[20];

            //Main loop to check for factors
            for ( int i = 1; i <= n; i++ )
            {
                //Checks if i divides evenly into number
                if( n % i == 0 )
                {
                    //Increase count of factors
                    count++;
                    //Add factor to array
                    factors = factors.Append(i).ToArray();
                }
            }

            //User number is negative or 0 or 1
            if ( count == 0 || count == 1 )
            {
                Console.WriteLine("Neither Prime or Composite");
            } else if ( count == 2) //Prime, only factors are 1 and itself
            {
                Console.WriteLine("Prime, Factors:");
                foreach ( int i in factors )
                {
                    if ( i != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            } else //More than 2 factors, Composite
            {
                Console.WriteLine("Composite, Factors:");
                foreach (int i in factors)
                {
                    if ( i != 0 )
                    {
                        Console.WriteLine(i);
                    }
                }
            }


        } catch (Exception e)
        {
            Console.WriteLine("Please Enter a Valid Number");
            Console.WriteLine(e.Message);
        }
    }
}
