using VotingApp;
UserController userController = new UserController();

Console.WriteLine("Voting App");

Category[] categories = new Category[3];

categories[0] = new Category();
categories[0].ID = 1;
categories[0].Title = "Bilim Kurgu";
categories[0].Vote = 0;

categories[1] = new Category();
categories[1].ID = 2;
categories[1].Title = "Komedi";
categories[1].Vote = 0;


categories[2] = new Category();
categories[2].ID = 3;
categories[2].Title = "Animasyon";
categories[2].Vote = 0;


Console.WriteLine("Hoşgeldiniz " +
    "\n Giriş Yapmak için login yaz, " +
    "\n Kayıt için register yaz, ");

var selection = Console.ReadLine().ToLower();

if (selection == "login")
{
    Console.WriteLine("kullanıcı adınızı giriniz : ");
    string userName = Console.ReadLine();
    Console.WriteLine("Şifre giriniz : ");
    string password = Console.ReadLine();


    string login = userController.Controller(userName, password);

    if (login == "success")
    {
        Console.WriteLine("Giriş Başarılı");
        Console.WriteLine("lütfen oylamaya katılın");
        foreach (var item in categories)
        {
            Console.Write(item.ID + " - " + item.Title + " = ");
            int puan = int.Parse(Console.ReadLine());
            item.Vote = puan;
        }
        Console.WriteLine("Oyladınız için teşekkürler :)");
    }
    else if (login == "error")
    {
        Console.WriteLine("Hatalı kullanıcı adı veya Hatalı şifre ! ");
    }
}

if (selection == "register")
{
    User user = new User();
    Console.WriteLine("Kayıt Ekranı");

    Console.Write("Kullanıcı Adı : ");
    user.UserName = Console.ReadLine();
    Console.Write("Şifrenizi Oluşturun : ");
    user.Password = Console.ReadLine();
    Console.Write("İsminiz : ");
    user.FirstName = Console.ReadLine();
    Console.Write("Soy isminiz : ");
    user.LastName = Console.ReadLine();
    user.IsDelete = false;
    user.CreateDate = DateTime.Now;

    bool c = userController.AddUser(user);
    if (c == true) Console.WriteLine("Kayıt başarılı");
    else Console.WriteLine("kullanıcı adı kullanımda");

}


Console.ReadKey();
