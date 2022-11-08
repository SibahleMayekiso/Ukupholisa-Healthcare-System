using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukupholisa_Healthcare_System.Data_Access_Layer;

namespace Ukupholisa_Healthcare_System.Business_Logic_Layer
{
    class Claims
    {
        private int claimid;
        private string status, policyid, clientid;
        private DateTime claimdate;

        public Claims()
        {

        }
        public Claims(int claimid, string policyid, string status, string cleintid, DateTime claimdate)
        {
            this.status = status;
            this.claimid = claimid;
            this.policyid = policyid;
            this.clientid = cleintid;
            this.claimdate = claimdate;
        }

        public int Claimid { get => claimid; set => claimid = value; }
        public string Policyid { get => policyid; set => policyid = value; }
        public string Clientid { get => clientid; set => clientid = value; }
        public DateTime Claimdate { get => claimdate; set => claimdate = value; }
        public string Status { get => status; set => status = value; }

        public BindingSource GetCliams(Claims claims)
        {
            CallData call = new CallData();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = call.ReadClaims(claims);
            return bindingSource;
        }

    }
}