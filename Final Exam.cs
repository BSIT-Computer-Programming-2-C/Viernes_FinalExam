using System;

public class Person
{

    private string name;
    private int age;
    private string address;


    public Person(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }


    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
                age = value;
            else
                throw new ArgumentException("Age must be positive");
        }
    }


    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("NASUS", 1000, "23 NEXUS VILLAGE");


            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Address: {person.Address}");


            person.Name = "NASUS";
            person.Age = 1000;
            person.Address = "23 NEXUS VILLAGE";


            person.DisplayInfo();
        }
    }
}