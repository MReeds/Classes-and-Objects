using System;

class Car
{
    string model;
    string color;
    int year;
    public void fullThrotle()
    {
        Console.WriteLine("The car is goin as fast as it can!");
    }

    static void Main(string[] args)
    {
        Car myObj = new Car();
        myObj.fullThrottle();

        Car Ford = new Car();
        Ford.model = "Mustang";
        Ford.color = "red";
        Ford.year = 1969;

        myObj.fullThrotle();
        Console.WriteLine(Ford.color);

        Person lulu = new Person(
            "Lulu",
            new DateTime(1934, 2, 14),
            new List<string>() { "Knitting", "Break dancing", "Lion taming" }
        );

        // Changing the Name property
        lulu.Name = "Lulu Rodriguez";

        // Calling the AddHobby method
        lulu.AddHobby("World domination");
    }
}

public class Person
{
    public string Name { get; set; }
    public DateTime BirthDay { get; set; }
    public List<string> Hobbies { get; set; }

    public Person(string name, DateTime birthday, List<string> hobbies)
    {
        this.Name = name;
        this.Birthday = birthday;
        this.Hobbies = hobbies;
    }

    public void AddHobby(string hobby)
    {
        Hobbies.Add(hobby);
    }
}