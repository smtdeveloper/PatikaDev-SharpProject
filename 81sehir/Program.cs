Console.WriteLine(
    "Türkiyedeki illerin plaka " +
    "kodlarının toplamı nedir ?");

int toplam = 0;

for (int i = 1; i <= 81; i++)
{
    toplam = toplam + i;
}

Console.Write(" Cevap : ");
Console.WriteLine(toplam);

Console.WriteLine(" Kara Düzen :) ");

for (int i = 5; i > 0; i--)
{
    Console.Write("5");
}

Console.WriteLine("");

for (int i = 4; i > 0; i--)
{
    Console.Write("4");
}

Console.WriteLine("");

for (int i = 3; i > 0; i--)
{
    Console.Write("3");
}

Console.WriteLine("");

for (int i = 2; i > 0; i--)
{
    Console.Write("2");
}

Console.WriteLine("");

for (int i = 1; i > 0; i--)
{
    Console.Write("1");
}

Console.WriteLine(" ");


Console.WriteLine("---------------------------");
Console.WriteLine(" Clean Code ");

for (int i = 5; i > 0; i--)
{
    for (int j = i; j > 0; j--)
    {
        Console.Write(i);
    }
    Console.WriteLine("");
}