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
        private int policyID;
        private DateTime startDate, endDate;

        public Policy(int policyID, DateTime startDate, DateTime endDate)
        {
            this.policyID = policyID;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public int PolicyID { get => policyID; set => policyID = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
    }
}
