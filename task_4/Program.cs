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

int AskUser2()
{
    Console.Write("Введите число: ");
    string? Ask = Console.ReadLine();
    if (Ask != null)
    {
        try
        {
            int op = int.Parse(Ask);
            return op;
        }
        catch (Exception)
        {
            Console.WriteLine("Введите верное число!");
            return AskUser2();
        }
    }
    else
    {
        Console.WriteLine("Введите верное число!");
        return AskUser2();
    }
}

int PrintSummNumsRecursive(int num){
    int sum=0;
    sum += num%10;
    if (num==0) return sum;
    //Console.WriteLine(sum);
    num=num/10;
    return PrintSummNumsRecursive(num)+sum;
}


Console.Write(PrintSummNumsRecursive(255)+ " ");
