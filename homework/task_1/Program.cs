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

int PrintNumsRecursive(int num)
{
    if (num == 0) return 1;
    Console.Write(num + " ");
    return PrintNumsRecursive(num - 1);
}

PrintNumsRecursive(AskUser());