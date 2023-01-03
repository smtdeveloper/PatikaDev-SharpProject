//Ortalama Hesaplama
//Kulanıcıdan alınan derinliğe göre fibonacci serisindeki rakamların ortalamasını alıp ekrana yazdıran uygulamayı yazınız.

//Dikkat Edilmesi Gereken Noktalar :
//Kod tekrarından kaçınılmalı
//Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.

Console.WriteLine("C# Projeleri\r\n" +
   "Ortalama Hesaplama\r\nKulanıcıdan alınan derinliğe göre fibonacci serisindeki rakamların ortalamasını alıp ekrana yazdıran uygulamayı yazınız." +
   "\r\n\r\n Dikkat Edilmesi Gereken Noktalar :" +
   "\r\n 1-) Kod tekrarından kaçınılmalı , " +
   "\r\n 2-) Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.");


Console.WriteLine("Lütfen fibonacci serisinin derinliğini giriniz: ");
int length = Convert.ToInt32(Console.ReadLine());

FibonacciCalculator fibonacci = new FibonacciCalculator();
AverageCalculator average = new AverageCalculator();

int[] fibonacciSeries = fibonacci.CalculateFibonacciSeries(length);
double averageResult = average.CalculateAverage(fibonacciSeries);

Console.WriteLine("Girilen derinlikteki fibonacci serisinin ortalaması: " + averageResult);
