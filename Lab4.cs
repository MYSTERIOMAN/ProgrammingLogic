using System;

class Program
{
    static void Main(string[] args)
    {
        //Problem 1
        for (int i = 1; i <= 10; i++)
        {
          Console.WriteLine(i);
        }
        Console.WriteLine("Program Complete");
        
        //Problem 2
        for (int i = 0; i <= 20; i = i + 2) 
        {
          Console.WriteLine(i);
        }
        Console.WriteLine("Program Complete");
        
        //Problem 3
        for (int i = 5; i >= 1; i = i - 1) 
        {
          Console.WriteLine(i);
        }
        Console.WriteLine("Program Complete");
        
        //Problem 4
        int x = 0;
        while (x <= 100)
        {
            Console.WriteLine("Enter a number greater than 100: ");
            x = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Program Complete");
        
        //Problem 5
        for (int i = 0; i <= 1000; i = i + 10) 
        {
          Console.WriteLine(i);
        }
        Console.WriteLine("Program Complete");
        
        //Problem 6
        for (int i = 1; i <= 10; i = i + 1)
        {
          for (int a = 1; a <= i; a = a + 1)
          {
            Console.Write("*");
          }
          Console.WriteLine();
        }
    }
}
