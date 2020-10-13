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
        Ford.year = 1969

        myObj.fullThrotle();
        Console.WriteLine(Ford.color);
    }
}