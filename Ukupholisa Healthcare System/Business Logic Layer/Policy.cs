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
        private int policyID, productID;
        private DateTime startDate, endDate;

        public Policy(int policyID, DateTime startDate, DateTime endDate, int productID)
        {
            this.policyID = policyID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.productID = productID;
        }

        public int PolicyID { get => policyID; set => policyID = value; }
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
    }
}
