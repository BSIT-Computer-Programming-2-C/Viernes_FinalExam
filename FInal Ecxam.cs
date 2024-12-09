using System;


public abstract class Animal
{
    
    public abstract void MakeSound();
}


public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow meow meooww!");
    }
}


public class Chicken : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("KOK KOK KOK");
    }
}

class Program
{
    static void Main(string[] args)
    {
     
        Animal myCat = new Cat(); 
        Animal myChicken = new Chicken(); 

       
        Console.WriteLine("cat makes sound:");
        myCat.MakeSound();

        Console.WriteLine("chicken makes sound:");
        myChicken.MakeSound();
    }
}

