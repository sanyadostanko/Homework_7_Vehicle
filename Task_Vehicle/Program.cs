using System;

public abstract class Vehicle
{
    public string Name { get; set; }
    public int Speed { get; set; }

    public Vehicle(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    public abstract void Go();
}


public class Car : Vehicle
{
    public Car(string name, int speed) : base(name, speed) { }

    public override void Go()
    {
        Console.WriteLine($"{Name} едет со скоростью {Speed} км/ч. Звук: Вжжжж!");
    }
}


public class Ship : Vehicle
{
    public Ship(string name, int speed) : base(name, speed) { }

    public override void Go()
    {
        Console.WriteLine($"{Name} плывет со скоростью {Speed} узлов. Звук: Шшшш!");
    }
}

public class Plane : Vehicle
{
    public Plane(string name, int speed) : base(name, speed) { }

    public override void Go()
    {
        Console.WriteLine($"{Name} летит со скоростью {Speed} км/ч. Звук: Уууу!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Vehicle car = new Car("Машинка", 120);
        Vehicle ship = new Ship("Корабль", 30);
        Vehicle plane = new Plane("Самолет", 900);

        car.Go();
        ship.Go();
        plane.Go();
    }
}
