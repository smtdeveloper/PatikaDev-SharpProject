
Console.WriteLine("Dersi geçmek için almam gereken minimum final notun kaç  olmalı ?  \n ");

while (true)
{
    Console.Write("Vize Notunu Gir : ");
    double gecmeNotu = 35;

    double vize = int.Parse(Console.ReadLine());

    double vizePuan = vize * 0.30;
    double finalPuan = gecmeNotu - vizePuan;
    double final = finalPuan * 1.3;
    Console.WriteLine("Geçmek için en az Final notun : " + final + " Olmalı !  \n ");
    

}


int? value = 1;




if (value == null)
{
    //
}



if (value is null)
{
    //
}