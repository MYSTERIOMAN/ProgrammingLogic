using System;


class Book
{
    private string title;
    private string author;

    public Book()
    {
        title = "Unknown Title";
        author = "Unknown Author";
    }


    public Book(string title)
    {
        this.title = title;
        author = "Unknown Author";
    }

   
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle()); 
        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle()); 
        Console.WriteLine(); 

        
        Book book2 = new Book("Learning C#");
        Console.WriteLine(book2.GetTitle());  
        Console.WriteLine(); 

        Book book3 = new Book("Advanced C#", "John Doe");
        Console.WriteLine("Title: " + book3.GetTitle());
        Console.WriteLine("Author: " + book3.GetAuthor());
        Console.WriteLine(); 

       
        Book book4 = new Book();
        book4.SetTitle("Mastering C#");
        book4.SetAuthor("Jane Smith");
        Console.WriteLine("Title: " + book4.GetTitle());
        Console.WriteLine("Author: " + book4.GetAuthor());
    }
}

