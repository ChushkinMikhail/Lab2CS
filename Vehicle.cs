// See https://aka.ms/new-console-template for more information
using System;
public class Vehicle
    {
    protected double x;
    protected double y;
    protected double price;
    protected double speed;
    protected int year;
    public Vehicle(double x, double y, double price, double speed, int year)
        {
        this.x = x;
        this.y = y;
        this.price = price;
        this.speed = speed;
        this.year = year;
        }
    public virtual void Print ()
        {
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(price);
        Console.WriteLine(speed);
        Console.WriteLine(year);
        }
    }
public class Plane : Vehicle
    {
    private double altitude;
    private int passengers;
    public Plane (double x, double y, double price, double speed, int year, double altitude, int passengers) : base(x, y, price, speed, year)
        {
        this.altitude = altitude;
        this.passengers = passengers;
        }
    public override void Print()
        {
        base.Print();
        Console.WriteLine (altitude);
        Console.WriteLine (passengers);
        }
    }
public class Car : Vehicle
    {
    private int passengers;
    public Car(double x, double y, double price, double speed, int year, int passengers) : base(x, y, price, speed, year)
        {
        this.passengers = passengers;
        }
    public override void Print()
        {
        base.Print();
        Console.WriteLine(passengers);
        }
    }
public class Ship : Vehicle
    {
    private int passengers;
    private string port; 

    public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
        : base(x, y, price, speed, year)
        {
        this.passengers = passengers;
        this.port = port;
        }

    public override void Print()
        {
        base.Print();
        Console.WriteLine(passengers);
        Console.WriteLine(port);
        }
    }
class Program
    {
    static void Main ()
        {
        Vehicle[] VVs = new Vehicle[]
            {
            new Plane (10, 20, 30, 40, 50, 60, 70),
            new Car   (80, 90, 100, 110, 120, 130),
            new Ship  (140, 150, 160, 170, 180, 190, "Сыктывкар")
            };

        foreach (var Vehicle in VVs)
            {
            Vehicle.Print();
            Console.WriteLine();
            }
        }
    }

