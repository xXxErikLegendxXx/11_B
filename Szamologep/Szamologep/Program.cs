Console.Write("Adj meg Egy számot : ");

double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Milyen műveletet szeRetnél elvégezni? (+, -, *, /): ");

char muvelet = Convert.ToChar(Console.ReadLine());

Console.Write("Adj meg egy más" +
    ": ");

double b = Convert.ToDouble(Console.ReadLine());

if (muvelet == '+')
{
    Console.WriteLine($"A művelet eredménye: {a + b}");
}
else if (muvelet == '-')
{
    Console.WriteLine($"A művelet eredménye: {a - b}");
}
else if (muvelet == '*')
{
    Console.WriteLine($"A művelet eredménye: {a * b}");
}
else if (muvelet == '/' && b!=0 )
{
    Console.WriteLine($"A művelet eredménye:  {a / b}");
}
else if (muvelet == '/' &&  b == 0) 
{
    Console.WriteLine("Nullával nem osztunk");
}
else
{
    Console.WriteLine("Nem értem");
}


