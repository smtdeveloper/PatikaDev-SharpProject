using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class UserController
    {
        InMemory inMemory = new InMemory();

        public string Controller(string cardNumber, string password)
        {
            User? user = inMemory.GetByUser(cardNumber);

            if (user.Password == password)
            {
                return "success";
            }
            else
            {
                return "error";
            }

        }

       
    }
}
