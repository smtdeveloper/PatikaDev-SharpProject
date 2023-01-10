using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class User
    {
        public int ID { get; set; }
        public string CardNumber { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }

    }
}
