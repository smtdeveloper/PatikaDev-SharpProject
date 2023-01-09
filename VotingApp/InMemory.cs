using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    public class InMemory
    {
        List<User> _users;
        public InMemory()
        {
            _users = new List<User>
            {
                new User { ID = 1, UserName = "smtcoder", Password = "123" , FirstName = "Samet" , LastName = "Akca" , CreateDate = new DateTime(1999, 07, 06) ,IsDelete = false},
                new User { ID = 1, UserName = "Beerten", Password = "147" , FirstName = "Beyza" , LastName = "Sukule" , CreateDate = new DateTime(1997, 11, 25) ,IsDelete = false},
                new User { ID = 1, UserName = "codi", Password = "258" , FirstName = "Codi" , LastName = "Coder" , CreateDate = new DateTime(2022, 08, 08) ,IsDelete = false}

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
        public User GetByUser(string userName)
        {
            return _users.Find(x => x.UserName == userName);
        }

    }
}
