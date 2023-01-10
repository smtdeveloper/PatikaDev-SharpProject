using ATM_App;
using System.IO;

Console.WriteLine("SMT ATM App");


string path = @"C:\ATM_logs\"; // Dosyanın kaydedileceği lokasyon
string fileName = "EOD_" + DateTime.Now.ToString("ddMMyyyy") + ".txt"; // Dosyanın adı
string fullPath = Path.Combine(path, fileName); // Tam dosya yolu

if (!Directory.Exists(path)) // Eğer klasör yoksa oluştur
{
    Directory.CreateDirectory(path);
}

UserController userController = new UserController();
InMemory inMemory = new InMemory();

Console.Write(" \n Kart Numarasınızı giriniz : ");
string cardNumber = Console.ReadLine();
Console.Write("Şifre giriniz :  ");
string password = Console.ReadLine();

string login = userController.Controller(cardNumber, password);

if (login == "success")
{
    while (true)
    {
        Console.WriteLine(" \n Hoşgeldiniz, \n 1. Bakiyeyi göster \n 2. Para yatır \n 3. Para Çek  \n 4. Çıkış ");
        int selection = int.Parse(Console.ReadLine());

        if (selection == 1)
        {
            User user = inMemory.GetByUser(cardNumber);
            Console.WriteLine("Güncel Bakiyeniz : " + user.Balance);
        }
        else if (selection == 2)
        {
            Console.WriteLine("yatırmak istediğiniz tutarı giriniz");
            int tutar = Convert.ToInt32(Console.ReadLine());

            User user = inMemory.GetByUser(cardNumber);
            int total = user.Balance + tutar;
            Console.WriteLine("İşlem başarılı güncel bakiyeniz = " + total);
            inMemory.UpdateBalance(cardNumber, total);


            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                // Logları veya fraud olabilecek yani hatalı giriş denemelerin loglarını sw nesnesine yazıyoruz
                sw.WriteLine("Gün Sonu Logları");
                sw.WriteLine("----------------");
                sw.WriteLine("\n #Kart Numarası :  " + cardNumber +
                    "\n - Yatıran Para : " + tutar +
                    "\n - Toplam Tutar : " + total);
            }


        }
        else if (selection == 3)
        {
            Console.Write("Çekmek istediğiniz tutarı giriniz : ");
            int tutar = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            User user = inMemory.GetByUser(cardNumber);
            if (tutar < user.Balance)
            {
                total = user.Balance - tutar;
                Console.WriteLine(" \n İşlem başarılı güncel bakiye : " + total);
                inMemory.UpdateBalance(cardNumber, total);
            }
            if (tutar > user.Balance)
            {
                Console.WriteLine("Bakiyeniz yetersiz ! ");
            }

            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                // Logları veya fraud olabilecek yani hatalı giriş denemelerin loglarını sw nesnesine yazıyoruz
                sw.WriteLine("Gün Sonu Logları");
                sw.WriteLine("----------------");
                sw.WriteLine("\n #Kart Numarası :  " + cardNumber +
                    "\n - Yatıran Para : " + tutar +
                    "\n - Toplam Tutar : " + total);
            }

        }
    }
}
else
{
    Console.WriteLine("Hatalı Şifre veya kart numarası ! ");
}




