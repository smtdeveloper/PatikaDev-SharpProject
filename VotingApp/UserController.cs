using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    public class UserController
    {
        InMemory inMemory = new InMemory();

        public string Controller(string UserName, string Password)
        {
            User? user = inMemory.GetByUser(UserName);

            if (user.Password == Password)
            {
                return "success";
            }
            else
            {
                return "error";
            }

        }

        public bool AddUser(User user)
        {
            int i = 0;
            List<User> users = inMemory.GetUsers();
            foreach (User item in users)
            {
                if (item.UserName == user.UserName)
                {
                    i++;
                }
            }
            if (i == 0)
            {
                User newUser = new User 
                { 
                    ID = users.Count + 1, 
                    UserName = user.UserName, 
                    Password = user.Password,
                    CreateDate = user.CreateDate,
                    FirstName= user.FirstName,
                    LastName= user.LastName,    
                    IsDelete = user.IsDelete    
                };
                inMemory.Add(newUser);
                return true;

            }
            else
            {
                return false;
            }

        }
    }
}
