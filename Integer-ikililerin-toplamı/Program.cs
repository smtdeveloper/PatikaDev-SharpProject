//Algoritma
//Ekrandan girilen n tane integer ikililerin toplamını alan, eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran,
//sayılar aynıysa toplamının karesini ekrana yazdıran console uygulamasını yazınız.

//Örnek Input: 2 3 1 5 2 5 3 3

//Output: 5 6 7 81

Console.WriteLine("Boşluk bırakıp sayılar girin, ikili sayıların toplamı " +
    "eğer  birbirinden farklıysa toplamlarını ekrana yazdıran, " +
    "sayılar aynıysa toplamının karesini ekrana yazdıran console uygulaması");

// Ekrana girilen ikilileri kullanıcıdan al.
string input = Console.ReadLine();

// Girilen ikilileri diziye ayır
string[] pairs = input.Split();

// İkilileri diziye ayırdıktan sonra dizinin uzunluğu n sayısı olacaktır
int n = pairs.Length / 2;

// Her ikilinin toplamını tutan dizi
int[] sums = new int[n];

// İkilileri gez ve her ikilinin toplamını hesapla - int'e ceviriyoruz. 
for (int i = 0; i < n; i++)
{
    // İkilinin ilk elemanı
    int x = int.Parse(pairs[2 * i]);
    // İkilinin ikinci elemanı
    int y = int.Parse(pairs[2 * i + 1]);

    // İkilinin toplamını hesapla
    sums[i] = x + y;
}

// Her ikilinin toplamını yazdır
for (int i = 0; i < n; i++)
{
    // Eğer ikilinin elemanları eşitse toplamın karesini yazdır
    if (sums[i] % 2 == 0)
    {
        Console.WriteLine(sums[i] * sums[i]);
    }
    // Değilse toplamını yazdır
    else
    {
        Console.WriteLine(sums[i]);
    }
}