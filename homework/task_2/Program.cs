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

int sum = 0;

int PrintSummRecursive(int start, int finish, int sum)
{
    if (start > finish) return sum;
    sum += start;
    //Console.Write(sum+ " ");
    return PrintSummRecursive(start + 1, finish, sum);
}

Console.Write(PrintSummRecursive(AskUser(), AskUser(), sum));