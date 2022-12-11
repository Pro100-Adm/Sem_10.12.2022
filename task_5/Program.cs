double DegreeOfNumber(int a, int b)// метод возведения в степень
{
    if(b == 0) // свойство степени 
        return 1;
    if(b % 2 == 1)
        return a * DegreeOfNumber(a, b -1);
        else
        return DegreeOfNumber(a * a, b / 2);
}

Console.WriteLine(DegreeOfNumber(5, 2));