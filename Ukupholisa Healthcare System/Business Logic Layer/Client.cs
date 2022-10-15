using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare_System.Business_Logic_Layer
{
    class Client
    {
        private int clientID;
        private string firstname, lastname, cellphoneNum, email;
        private int age;

        public Client(string name, string surname, int age)
        {
            this.firstname = name;
            this.lastname = surname;
            this.age = age;
        }

        public int ClientID { get => clientID; set => clientID = value; }
        public string FirstName { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Age { get => age; set => age = value; }
        public string CellphoneNum { get => cellphoneNum; set => cellphoneNum = value; }
        public string Email { get => email; set => email = value; }
    }
}
