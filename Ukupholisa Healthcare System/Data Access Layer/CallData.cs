using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ukupholisa_Healthcare_System.Business_Logic_Layer;

namespace Ukupholisa_Healthcare_System.Data_Access_Layer
{
    class CallData
    {
        //Connection to a local Database that will be used by the application
        SqlConnection conn = new SqlConnection(@"Data Source=.; Initial Catalog = UkupholisaHealthcareDB; Integrated Security = SSPI");
        SqlCommand cmd;
        string queryString;

        //CRUD Operations and Methods
        //Create Methods
        //Read Methods

        public SqlDataAdapter ViewCallLogs()
        {
            string query = @"SELECT * FROM CallCenter";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            return adapter;
        }

        public SqlDataAdapter ViewClientCallLogs(Client client)
        {
            string query = string.Format(@"SELECT * FROM CallCenter WHERE ClientID = {0}", client.ClientID);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            return adapter;
        }
        //Update Methods
        //Delete Methods
    }
}
