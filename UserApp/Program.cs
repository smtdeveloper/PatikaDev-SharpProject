using UserApp;

Console.WriteLine("UserApp");


User user1 = new User
{
    Id = 1,
    Name = "Çiğdem",
    LastName = "Kahya",
    Isdelete = false,
};



User user2 = new User
{
    Id = 2,
    Name = "Samet",
    LastName = "Akca",
    Isdelete = false,
};

    
User[] users = { user1, user2 };

foreach (var user in users)
{
    Console.WriteLine(user.Name);
}



