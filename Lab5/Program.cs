namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        string[] names = new string[4];
        names[0] = "Spring";
        names[1] = "Summer";
        names[2] = "Fall";
        names[3] = "Winter";

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        string[] days = new string[7];
        days[0] = "Monday";
        days[1] = "Tuesday";
        days[2] = "Wednesday";
        days[3] = "Thursday";
        days[4] = "Friday";
        days[5] = "Saturday";
        days[6] = "Sunday";

        Console.WriteLine("Enter a number 1-7: ");
        int daynum = Convert.ToInt32(Console.ReadLine());
            if (daynum < 1 || daynum > 7)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                Console.WriteLine($"The day is {days[daynum - 1]}");
            }
            
        
    
    }
}
