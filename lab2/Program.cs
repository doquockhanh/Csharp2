class Program
{
    static void Main()
    {
        Console.WriteLine("Bai 1");
        var bai1 = new Bai1();
        bai1.bai1a();
        bai1.bai1b();
        bai1.bai1c();
        Console.WriteLine();

        Console.WriteLine("Bai 2");
        var bai2 = new Bai2();
        bai2.bai2a();
        bai2.bai2b();
        Console.WriteLine();

        Console.WriteLine("Bai 3");
        UserData u = new UserData("1", "khanh roll den", new List<float>() {10, 9, 8, 7.5f, 2, 1.4f});
        u.showInfo();
    }
}

class Bai1
{
    dynamic x = 10;
    public void bai1a()
    {
        Console.WriteLine("x: " + x);
    }

    public void bai1b()
    {
        getDetail(10);
        getDetail(11);
        getDetail("acsc");
    }

    public void getDetail(dynamic value)
    {
        Console.WriteLine("value: " + value);
    }

    public void bai1c()
    {
        UserData u = new UserData("1", "khanh roll den", 1);
        u.showInfo();
    }
}

class Bai2
{
    public void bai2a()
    {
        var userInfo = new
        {
            id = 1,
            name = "ruoc em ve jinx",
            isPlaying = true,
            bag = new
            {
                skins = 199,
                cups = 99,
            }
        };
        Console.WriteLine("ID: " + userInfo.id);
        Console.WriteLine("Name: " + userInfo.name);
        Console.WriteLine("Playing: " + userInfo.isPlaying);
        Console.WriteLine("Skins: " + userInfo.bag.skins);
        Console.WriteLine("Cups: " + userInfo.bag.cups);
    }

    public void bai2b()
    {
        int y = 10;
        Action<int> action = delegate (int x)
        {
            int sum = x + y;
            int sub = x - y;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Sub: " + sub);
        };

        action(5);
    }
}

class UserData
{
    public string id;
    public string name;
    public int level;

    public List<float> scores;

    public UserData(string id, string name, int level)
    {
        this.id = id;
        this.name = name;
        this.level = level;
    }

    public UserData(string id, string name, List<float> scores)
    {
        this.id = id;
        this.name = name;
        this.scores = scores;
    }

    public void showInfo()
    {
        string info = $"ID: {id} | Name: {name}" +
              (level != 0 ? $" | Level: {level}" : "") +
              (scores?.Count > 0 ? $" | Scores: {string.Join("; ", scores)}" : "");
        Console.WriteLine(info);
    }
}