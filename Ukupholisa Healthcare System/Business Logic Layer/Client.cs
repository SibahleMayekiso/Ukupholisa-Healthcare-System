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
        private string clientID;
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

        public string ClientID { get => clientID; set => clientID = value; }
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

        public string AddPersonValidation(string name, string surname, string phoneNumber, string email, string relation, string status, string street, string region)
        {
            if (!(name == null | surname == null | phoneNumber == null | email == null | relation == null | status == null | street == null | region == null))
            {
                return ("Please Fill in all Fields");


            }
            else
            {
                return ("Added Succesfully");
            }
        }

        public string UpdatePersonValidation(string name, string surname, string phoneNumber, string email, string relation, string status, string street, string region)
        {
            if (!(name == null | surname == null | phoneNumber == null | email == null | relation == null | status == null | street == null | region == null))
            {
                return ("Please Fill in all Fields");


            }
            else
            {
                return ("Added Succesfully");
            }

        }
    }
}
