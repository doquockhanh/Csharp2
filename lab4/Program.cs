using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        bai1();
        bai2();
        bai3();
    }

    public static void bai1()
    {
        Console.WriteLine("Bai 1");
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<int> list2 = list.FindAll(item => item % 2 == 0);
        foreach (int item in list2)
        {
            Console.WriteLine(item);
        }
    }

    public static void bai2()
    {
        Console.WriteLine("\nBai 2");
        List<UserData> users = new List<UserData>();
        users.Add(new UserData("Khanh", 5));
        users.Add(new UserData("Huy", 2));
        users.Add(new UserData("Nam", 3));
        users.Add(new UserData("Lmao", 8));
        users.Add(new UserData("GG", 9));
        users.Add(new UserData("Surrender", 0));

        var selectedDataUsers = users.Select(u => new { u.name, u.level });
        foreach (var item in selectedDataUsers)
        {
            Console.WriteLine($"Name: {item.name} | Level: {item.level}");
        }
    }

    public static void bai3()
    {
        Console.WriteLine("\nBai 3");
        List<Student> students = new List<Student>()  {
            new Student("Khanh", 15),
            new Student("Marry", 18),
            new Student("Nood", 20),
            new Student("Cancel", 10),
            new Student("LOW K", 22),
            new Student("Emily", 16)
        };

        var result =
            from student in students
            where student.age > 12 && student.age < 20
            select student;

        var result2 = students
            .Where(student => student.age > 12 && student.age < 20);


        Console.WriteLine("LINQ Querry Syntax students (12 < age < 20)");
        foreach (var student in result)
        {
            Console.WriteLine($"Name: {student.name}, Age: {student.age}");
        }

        Console.WriteLine("LINQ Method Syntax students (12 < age < 20)");
        foreach (var student in result2)
        {
            Console.WriteLine($"Name: {student.name}, Age: {student.age}");
        }
    }
}

class UserData
{
    public string name;
    public int level;

    public UserData(string name, int level)
    {
        this.name = name;
        this.level = level;
    }
}

class Student
{
    public string name;
    public int age;

    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}