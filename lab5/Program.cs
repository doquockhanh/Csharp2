using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

class Program
{
    static void Main()
    {
        List<UserData> userDatas = new List<UserData>() {
            new UserData("Khanh", 34, 99.9f, "Carry", 999),
            new UserData("Bee", 18, 50f, "SP", 10),
            new UserData("Zoe", 99, 45f, "Tank", 432),
            new UserData("Azir", 2, 65f, "AP", 34),
            new UserData("Rakan", 5, 43.5f, "AP", 73)
        };

        bai1(userDatas);
        bai2(userDatas);
        bai3(userDatas);
    }

    static void bai1(List<UserData> userDatas)
    {
        Console.WriteLine("Bai 1: ");

        Console.WriteLine("\nA: Show list");
        foreach (UserData user in userDatas)
            Console.WriteLine($"- Name: {user.name} | Rank: {user.rank} | WinRate: {user.winRate}% | Type: {user.type} | Skins: {user.skins}");

        Console.WriteLine("\nB: Sap xep theo Rank giam ");
        var b = userDatas.OrderByDescending(u => u.rank);
        foreach (var user in b)
            Console.WriteLine($"- Name: {user.name}| Rank: {user.rank}");

        Console.WriteLine("\nC: sap xep theo Name and Skin giam");
        var c = userDatas.OrderByDescending(u => u.name).ThenByDescending(u => u.skins);
        foreach (var user in c)
            Console.WriteLine($"- Name: {user.name}| Skin: {user.skins}");

        Console.WriteLine("\nD: Users ten bat dau la 'B'");
        var d = userDatas.Where(u => u.name.StartsWith("B"));
        foreach (var user in d)
            Console.WriteLine($"- Name: {user.name}");
    }

    static void bai2(List<UserData> userDatas)
    {
        Console.WriteLine("\nBai 2: ");

        Console.WriteLine("A: Users winRate > 50: ");
        var a = userDatas.Where(u => u.winRate > 50);
        foreach (var user in a)
            Console.WriteLine($"- Name: {user.name} | Winrate: {user.winRate}%");

        var b = userDatas.OrderByDescending(u => u.winRate).FirstOrDefault();
        if (b != null)
            Console.WriteLine($"\nB: Users WinRate cao nhat: {b.name} ({b.winRate}%)");
        else
            Console.WriteLine($"\nB: Khong tim thay");

        Console.WriteLine($"\nC: So luong tai khoan trong UserData la: {userDatas.Count}");
    }

    static void bai3(List<UserData> userDatas)
    {
        Console.WriteLine("\nBai 3: \n");
        ILookup<string, UserData> dataLookup = userDatas.ToLookup(user => user.type);
        foreach (var group in dataLookup)
        {
            Console.WriteLine($"Key: {group.Key}");
            foreach (UserData user in group)
            {
                Console.WriteLine($" - Name: {user.name} | Rank: {user.rank} | WinRate: {user.winRate}% | Type: {user.type} | Skins: {user.skins}");
            }
            Console.WriteLine("");
        }
    }
}
class UserData
{
    public string name;
    public int rank;
    public float winRate;
    public string type;
    public int skins;

    public UserData(string name, int rank, float winRate, string type, int skins)
    {
        this.name = name;
        this.rank = rank;
        this.winRate = winRate;
        this.type = type;
        this.skins = skins;
    }
}