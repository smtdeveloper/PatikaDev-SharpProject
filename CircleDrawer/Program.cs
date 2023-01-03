Console.WriteLine("Draw Circle App");

// Kullanıcıdan yarıçap değerini al
Console.WriteLine("Lütfen dairenin yarıçapını giriniz:");
int radius = int.Parse(Console.ReadLine());

// Daire çizme metodunu çağır
DrawCircle(radius);


static void DrawCircle(int radius)
{

    // Daire çizme işlemleri

    for (double y = -radius; y <= radius; y ++)
    {
        for (double x = -radius; x <= radius; x += 0.5)
        {
            if ( (x * x) + (y * y) >= radius * radius)
                Console.Write("-");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}