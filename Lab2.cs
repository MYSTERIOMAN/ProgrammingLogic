namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        // My github is failing to commit & push everytime I try it just loads forever, I hope this file is acceptable I do not know how to manually create a new folder with a new .cs file
        // Part 1
        int p1int = 7;
        double p1doub = 3.14159265;
        float p1float = 6.18F;
        char p1char = 'Z';
        bool p1bool = false;
        string p1str = "String";

        Console.WriteLine(p1int + "\n" + p1doub + "\n" + p1float + "\n" + p1char + "\n" + p1bool + "\n" + p1str);

        //Part 2
        double p2dub = 9.78;
        int p2int = (int) p2dub;
        string p2i2s = Convert.ToString(p2int);
        string p2b2s = Convert.ToString(p1bool);

        Console.WriteLine("Double to int: " + p2dub + "\n" + "Int to string: " + p2i2s + "\n" + "Bool to string: " + p2b2s);

        //Part 3
        Console.WriteLine("Enter your username: ");
        string usern = Console.ReadLine();
        Console.WriteLine("Enter your age: ");
        string usera = Console.ReadLine();
        int useraint = Convert.ToInt32(usera);

        Console.WriteLine("Hello " + usern + "!" + "\n" + "You are " + useraint + " years old!");

        //Part 4
        int num1 = 92;
        int num2 = 127;
        Console.WriteLine("My two integers are " + num1 + " and " + num2);

        int num1a = num1 + 10;
        Console.WriteLine(num1 + " + 10 = " + num1a);
        int num2a = num2 + 10;
        Console.WriteLine(num2 + " + 10 = " + num2a);
        int num1s = num1 - 2;
        Console.WriteLine(num1 + " - 2 = " + num1s);
        int num2s = num2 - 2;
        Console.WriteLine(num2 + " - 2 = " + num2s);
        int num1m = num1 * 3;
        Console.WriteLine(num1 + " * 3 = " + num1m);
        int num2m = num2 * 3;
        Console.WriteLine(num2 + " * 3 = " + num2m);
        int num1d = num1 / 2;
        Console.WriteLine(num1 + " / 2 = " + num1d);
        int num2d = num2 / 2;
        Console.WriteLine(num2 + " / 2 = " + num2d);
        int num1r = num1 % 2;
        Console.WriteLine("The remainder of " + num1 + " / 2 = " + num1r);
        int num2r = num2 % 2;
        Console.WriteLine("The remainder of " + num2 + " / 2 = " + num2r);

        //Part 5
        float p5fl = 1.123456789F;
        double p5dbl = 1.123456789;
        Console.WriteLine(p5fl + "\n" + p5dbl);
        //^Float cuts out after the 7th decimal^

        //Part 6
        int p6int = 10;
        p6int++;
        Console.WriteLine(p6int);
        p6int--;
        Console.WriteLine(p6int);
    }
}
