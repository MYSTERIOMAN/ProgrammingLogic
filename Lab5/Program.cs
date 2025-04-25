namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        //Problem 1
        string[] names = new string[4];
        names[0] = "Spring";
        names[1] = "Summer";
        names[2] = "Fall";
        names[3] = "Winter";

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        //Problem 2
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
            

            //Problem 3
            string[] books = new string[3];
            books[0] = "Harry Potter";
            books[1] = "Hunger Games";
            books[2] = "The Alchemist";

            string[] authors = new string[3];
            authors[0] = "J. K. Rowling";
            authors[1] = "Suzanne Collins";
            authors[2] = "Paulo Coelho";

            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine($"{books[i]} by {authors[i]}");
            }


            //Problem 4
            int[] temperatures = {65, 72, 78, 70, 68};
            Array.Sort(temperatures);
            Console.WriteLine("Sorted Temps: ");
            foreach (int i in temperatures)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Highest Temp: {temperatures.Max()}");
            Console.WriteLine($"Highest Temp: {temperatures.Min()}");
    

            //Problem 5
            int[] nums = {5, 4, 3, 2, 1};
            Array.Reverse(nums);
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

    }
}
