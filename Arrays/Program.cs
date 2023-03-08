Console.WriteLine("Arrays");


// VeriTipi[] değişkenAdı = { değerler };


string[] names = { "Samet", "Çiğdem" , "Ayşe" , "Furkan" , "Eslem" };


Console.WriteLine(" -------- for ");

Array.Sort(names);

for (int i = 0 ; i < names.Length ; i++ )
{
    Console.WriteLine(names[i]);
}

foreach (var item in names)
{

}

int[] number = { 1, 2, 3, 4, 5 };



