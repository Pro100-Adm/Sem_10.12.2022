int AskUser()
{
    Console.Write("Введите число: ");
    string? Ask = Console.ReadLine();
    if (Ask != null)
    {
        try
        {
            int op = int.Parse(Ask);
            if (op > 0) return op;
            else
            {
                Console.WriteLine("Введите число > 0!");
                return AskUser();
            };
        }
        catch (Exception)
        {
            Console.WriteLine("Введите верное число!");
            return AskUser();
        }
    }
    else
    {
        Console.WriteLine("Введите верное число!");
        return AskUser();
    }
}

int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else
        if (n != 0 && m == 0) return Akkerman(n - 1, 1);
    else return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.Write(Akkerman(AskUser(), AskUser()));