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
        private int claimid, policyid, cleintid;
        private string Staus;
        private DateTime Claimdate;

        public Claims()
        {

        }
        public Claims(int claimid, int policyid, string status, int cleintid, DateTime claimdate)
        {
            this.Staus = status;
            this.claimid = claimid;
            this.policyid = policyid;
            this.cleintid = cleintid;
            Claimdate = claimdate;
        }

        public int Claimid { get => claimid; set => claimid = value; }
        public int Policyid { get => policyid; set => policyid = value; }
        public int Cleintid { get => cleintid; set => cleintid = value; }
        public DateTime Claimdate1 { get => Claimdate; set => Claimdate = value; }
        public string Status1 { get => Status1; set => Status1 = value; }

        public BindingSource GetCliams(Claims claims)
        {
            CallData call = new CallData();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = call.ReadClaims(claims);
            return bindingSource;
        }

    }
}