using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukupholisa_Healthcare_System.Data_Access_Layer;

namespace Ukupholisa_Healthcare_System.Business_Logic_Layer
{
    //Class is for each client's policy
    class Policy
    {
        private int productID;
        private string policyID;
        private DateTime startDate, endDate;

        public Policy()
        {

        }

        public Policy(string policyID, DateTime startDate, DateTime endDate, int productID)
        {
            this.policyID = policyID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.productID = productID;
        }

        public string PolicyID { get => policyID; set => policyID = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public int ProductID { get => productID; set => productID = value; }


        public BindingSource GetAllPolicies()
        {
            PolicyData policyData = new PolicyData();
            BindingSource source = new BindingSource();
            source.DataSource = policyData.ReadAllPolicies();
            return source;
        }

        public BindingSource GetClientPolicies(Client client)
        {
            PolicyData policyData = new PolicyData();
            BindingSource source = new BindingSource();
            source.DataSource = policyData.ReadClientPolicy(client);
            return source;
        }

        public BindingSource GenerateReport()
        {
            PolicyData policyData = new PolicyData();
            BindingSource source = new BindingSource();
            source.DataSource = policyData.GetPerformanceReport();
            return source;
        }

        public BindingSource GenerateReportByPeriod(DateTime start, DateTime end)
        {
            PolicyData policyData = new PolicyData();
            BindingSource source = new BindingSource();
            source.DataSource = policyData.GetPerformanceReportByDate(start, end);
            return source;
        }
        //Insert Methods
        #region Insert methods
        public string InsertClientDetails(Client client)
        {
            ClientData clientData = new ClientData();
            client.ClientID = clientData.GenerateClientID(client);
            return clientData.InsertClientData(client);
        }
        public string InsertClientPolicyDetails(Policy policy, string importanceLevel, string clientID)
        {
            PolicyData policyData = new PolicyData();
            return policyData.InsertPolicyData(policy, importanceLevel, clientID);
        }
        #endregion
    }
}
