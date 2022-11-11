using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukupholisa_Healthcare_System.Data_Access_Layer;

namespace Ukupholisa_Healthcare_System.Business_Logic_Layer
{
    class Call
    {
        private int callID, claim_Amount;
        private bool answer_Call;
        private string claim_Details;

        public Call()
        {

        }

        public Call(bool answer_Call, string claim_Details, int claim_Amount, int callID)
        {
            this.answer_Call = answer_Call;
            this.claim_Details = claim_Details;
            this.claim_Amount = claim_Amount;
            this.callID = callID;
        }

        public bool Answer_Call { get => answer_Call; set => answer_Call = value; }
        public string Claim_Details { get => claim_Details; set => claim_Details = value; }
        public int Claim_Amount { get => claim_Amount; set => claim_Amount = value; }
        public int CallID { get => callID; set => callID = value; }

        public BindingSource GetAllCallLogs()
        {
            CallData callData = new CallData();
            BindingSource source = new BindingSource();
            source.DataSource = callData.ReadCallLogs();
            return source;
        }
        public BindingSource GetClientCallLogs(Client client)
        {
            CallData callData = new CallData();
            BindingSource source = new BindingSource();
            source.DataSource = callData.ReadClientCallLogs(client);
            return source;
        }

        public string ClaimApproval(Policy policy, string treatmentID)
        {
            CallData call = new CallData();
            string status = call.GetTreatmentsTable(policy, treatmentID);

            return status;
        }

        public string AddPersonValidation(string name, string surname, string phoneNumber, string email)
        {
            if (!(name == null | surname == null | phoneNumber == null | email == null))
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
