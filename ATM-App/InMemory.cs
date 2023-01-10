using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class InMemory
    {
        List<User> _users;
        public InMemory()
        {
            _users = new List<User>
            {
                new User { ID = 1, CardNumber = "000", Password = "123" , FirstName = "Samet" , LastName = "Akca" , CreateDate = new DateTime(1999, 07, 06) ,IsDelete = false , Balance = 180},
                new User { ID = 1, CardNumber = "34324314", Password = "1473" , FirstName = "Beyza" , LastName = "Sukule" , CreateDate = new DateTime(1997, 11, 25) ,IsDelete = false , Balance = 75 },
                new User { ID = 1, CardNumber = "1412412412", Password = "2538" , FirstName = "Codi" , LastName = "Coder" , CreateDate = new DateTime(2022, 08, 08) ,IsDelete = false , Balance = 90 },
                new User { ID = 1, CardNumber = "3435353445", Password = "3322" , FirstName = "Beyza" , LastName = "Başak" , CreateDate = new DateTime(1994, 01, 04) ,IsDelete = false , Balance = 950 }

            };

        }
        public void Add(User user)
        {
            _users.Add(user);
        }
        public List<User> GetUsers()
        {
            return _users;
        }
        public User GetByUser(string cardNumber)
        {
            return _users.Find(x => x.CardNumber == cardNumber);
        }
        public void UpdateBalance(string cardNumber, int balance)
        {
            User user = _users.Find(x => x.CardNumber == cardNumber);
            user.Balance = balance;

        }
    }
}
