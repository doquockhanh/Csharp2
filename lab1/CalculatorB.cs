public partial class Calculator
{
    public int cong()
    {
        return NumberA + NumberB;
    }

    public int tru()
    {
        return NumberA - NumberB;
    }

    public int nhan()
    {
        return NumberA * NumberB;
    }

    public int chia()
    {
        if (NumberB != 0)
        {
            return NumberA / NumberB;
        }
        else
        {
            Console.WriteLine("khong chia duoc cho 0");
            return 0;
        }
    }
}