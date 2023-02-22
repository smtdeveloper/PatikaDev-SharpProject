Console.WriteLine("Hello, World!");




//1. Fibonacci Sayıları
//Fibonacci sayıları, her sayının kendinden önceki iki sayının toplamı olduğu bir dizi sayıdır.
//Örneğin, 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ... şeklinde devam eder. Fibonacci sayılarını recursive fonksiyon ile hesaplamak mümkündür.

 static int Fibonacci(int n)
{
    if (n <= 1)
    {
        return n;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

Fibonacci(1);


//2. Aşağıda, bir dizindeki tüm dosya adlarını yazdırmak için kullanılabilecek bir C# örneği verilmiştir:
static void ListFiles(string path)
{
    foreach (string file in Directory.GetFiles(path))
    {
        Console.WriteLine(file);
    }

    foreach (string directory in Directory.GetDirectories(path))
    {
        ListFiles(directory);
    }
}

string path = @"C:\Users\Username\Desktop\TestFolder";
ListFiles(path);


//3. Konsoldan kategori örneği yapmak için, bir kategori ağacı yapısı oluşturabiliriz.
//Her kategori, alt kategorilere sahip olabilir. Aşağıda, kategori ağacı yapısı için bir C# sınıfı verilmiştir:

public class Category
{
    public string Name { get; set; }
    public List<Category> Subcategories { get; set; }

    public Category(string name)
    {
        Name = name;
        Subcategories = new List<Category>();
    }

    public void Print(int indent = 0)
    {
        Console.WriteLine(new string(' ', indent) + Name);

        foreach (Category subcategory in Subcategories)
        {
            subcategory.Print(indent + 2);
        }
    }
}

//Bu sınıf, bir kategori ismi ve alt kategorilerin listesi içerir.
//Ayrıca, Print() metodu, kategoriyi ekrana yazdırmak için bir girinti değeri alır.

