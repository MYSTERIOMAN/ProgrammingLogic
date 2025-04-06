namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        //Part 1
        int a = 10;
        int b = 5;
        int c = 15;
        Console.WriteLine(a > b);
        Console.WriteLine(a < c);
        Console.WriteLine(a > b && a > c);
        Console.WriteLine(a > b || a > c);

        //Part 2
        bool israining = true;
        bool haveumbrella = false;
        if (israining == true)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");
        }

        //Part 3
        Console.WriteLine("Enter age:");
        int age = int.Parse(Console.ReadLine());
        if (age <= 5)
        {
            Console.WriteLine("Ticket is free!");
        }
        else if (age <= 12)
        {
            Console.WriteLine("Child ticket: $5");
        }
        else if (age <= 64)
        {
            Console.WriteLine("Standard ticket: $10");
        }
        else
        {
            Console.WriteLine("Senior ticket: $6");
        }

        //Part 4
        Console.WriteLine("Enter day of the week (1-7): ");
        int dayn = int.Parse(Console.ReadLine());
        
        if (dayn >= 1 && dayn <=7)
        {
            int day = dayn;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid Day!");
        }
    }
}
