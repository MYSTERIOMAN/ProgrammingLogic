using System;


class Animal
{
    public virtual void Animalsound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Cat : Animal
{
    public override void Animalsound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

class Dog : Animal
{
    public override void Animalsound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}



class Program
{
    static void Main(string[] args)
    {
        Animal genericAnimal = new Animal();
        Animal kitty = new Cat();
        Animal fido = new Dog();

        genericAnimal.Animalsound();
        kitty.Animalsound();
        fido.Animalsound();
    }
}
