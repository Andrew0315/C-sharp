using System;
class Program
{
    public static void Main(string[] args)
    {
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{1}", n, Program.F(n));
        Console.ReadKey(true);
    }
    static ulong F(int n)
    {
        if (1 == n)
            return 1;
        else
        {
            ulong t, t1 = 0, t2 = 1;
            for (int i = 2; i <= n; i++)
            {
                t = t2;
                t2 += t1;
            }
            return t2;
        }
    }
}
