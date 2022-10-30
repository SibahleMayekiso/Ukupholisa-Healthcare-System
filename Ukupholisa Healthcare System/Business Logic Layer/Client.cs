using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukupholisa_Healthcare_System.Data_Access_Layer;

namespace Ukupholisa_Healthcare_System.Business_Logic_Layer
{
    class Client
    {
        private int clientID;
        private string firstname, lastname, cellphoneNum, email;
        private int age;

        public Client()
        {

        }

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

        public BindingSource GetClientDetailTable()
        {
            ClientData clientData = new ClientData();
            BindingSource source = new BindingSource();
            source.DataSource = clientData.ReadAllClients();
            return source;
        }

        public void UpdateClientDetails(Client client)
        {
            ClientData clientData = new ClientData();
            clientData.UpdateClientDetails(client);
        }
    }
}
