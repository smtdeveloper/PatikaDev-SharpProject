int size;
Console.WriteLine("Enter size of triangle: ");
size = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= size; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.ReadLine();