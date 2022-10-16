using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
