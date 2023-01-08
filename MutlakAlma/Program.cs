//Algoritma
//Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna bakan. Küçük olanların farklarının toplamını, büyük ise de farkların mutlak karelerini alarak toplayıp ekrana yazdıran console uygulamasını yazınız.

//Örnek: Input: 56 45 68 77

//Output: 33 101

Console.WriteLine("Boşluk bırakarak sayılar girin : ");
string input = Console.ReadLine();

string[] strings = input.Split();

int[] numbers = new int[strings.Length];

int sumofDifferences = 0;
double absoluteSquaring = 0;

for (int i = 0; i < strings.Length; i++)
{
    int x = int.Parse(strings[i]);
    numbers[i] = x;

    if (numbers[i] <= 67)
    {
        sumofDifferences += 67 - numbers[i];
        Console.WriteLine(" 67'den Küçük olanların farklarının toplamı :" + sumofDifferences);
    }
    else
    {
        absoluteSquaring += Math.Pow((numbers[i] - 67), 2);
        Console.WriteLine("67'den büyük farkların mutlak karelerini alarak toplamı : " +absoluteSquaring);
    }

}
//Math.Pow(x,y): Bu metot sayesinde vereceğimiz iki parametrenin ilk verilen değeri taban,
//ikinci verilen değeri üst olarak kabul ederek üs alma işlemi gerçekleştirir. 
