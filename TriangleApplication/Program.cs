
//Algoritma
//Kullanıcıdan alınan boyut bilgisine göre console'a Üçgen çizen uygulamayı yazınız.

//Dikkat Edilmesi Gereken Noktalar :

//Kod tekrarından kaçınılmalı
//Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.

Console.WriteLine("Draw Triangle App");

int size;
Console.WriteLine("Enter size of triangle: ");
size = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= size; i++)
{
    for (int j = 1; j <= size - i; j++)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= 2 * i - 1; j++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}

Console.ReadLine();
