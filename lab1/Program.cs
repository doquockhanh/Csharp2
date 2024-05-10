using System;

class Program
{
    static void Main()
    {
        // Bai 1
        Console.WriteLine("Bai 1");
        Console.WriteLine("ID " + UserData.ID);
        Console.WriteLine("Name " + UserData.Name);
        Console.WriteLine("Health " + UserData.Health);
        Console.WriteLine("Point " + UserData.Point);

        // Bai 2
        Console.WriteLine("Bai 2");
        var maps1 = new MapLab1("2024", "URF");
        Console.WriteLine(maps1.ShowData());

        // Bai 3
        Console.WriteLine("Bai 3");
        Calculator calculator = new Calculator();
        calculator.NumberA = 10;
        calculator.NumberB = 5;

        Console.WriteLine("So A: " + calculator.NumberA);
        Console.WriteLine("So B: " + calculator.NumberB);
        Console.WriteLine("cong: " + calculator.cong());
        Console.WriteLine("tru: " + calculator.tru());
        Console.WriteLine("nhan: " + calculator.nhan());
        if (calculator.NumberB != 0)
        {
            Console.WriteLine("chia: " + calculator.chia());
        }
        else
        {
            Console.WriteLine("khong chia duoc cho 0");
        }

    }
}

public static class UserData
{
    public static string ID;
    public static string Name;
    public static float Health;
    public static int Point;

    static UserData()
    {
        ID = "2024";
        Name = "Hide on Bush";
        Health = 100f;
        Point = 100;
    }
}

class MapLab1
{
    public string Name;
    public string ID;

    static string _inGame = "LOL";

    public MapLab1(string id, string name)
    {
        ID = id;
        Name = name;
    }

    public string ShowData()
    {
        return "ID " + ID + " Name " + Name + " inGame " + _inGame;
    }
}