Console.Write("Adj meg egy számot : ");

double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Milyen műveletet szeretnél elvégezni? (+, -, *, /): ");

char muvelet = Convert.ToChar(Console.ReadLine());

Console.Write("Adj meg egy másik számot: ");

double b = Convert.ToDouble(Console.ReadLine());


if (muvelet == '+')
{

    Console.WriteLine($"Az művelet eredménye: {a+b}");


}
else if (muvelet == '-')
{

    Console.WriteLine($"A művelet eredménye: {a - b }");


}
else if (muvelet == '*')
{

    Console.WriteLine($"A művelet eredménye: { a* b}");


}

if (muvelet == '/' && a != 0 && b!=0 )
{

    Console.WriteLine($"A művelet eredménye:  {a / b}");


}
else if (muvelet == '/' && a == 0  || b == 0) 
{

    Console.WriteLine("Nullával nem osztunk");

}

else
{

    Console.WriteLine("Nem értem");

}


