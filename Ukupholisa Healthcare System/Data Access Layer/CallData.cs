using System;
using System.Collections.Generic;
using System.Data;
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
        #region Read Methods
        public DataTable ReadCallLogs()
        {
            string query = @"SELECT * FROM CallCenter";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable ReadClientCallLogs(Client client)
        {
            string query = string.Format(@"SELECT * FROM CallCenter WHERE ClientID = {0}", client.ClientID);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        #endregion Read Methods
        //Update Methods
        /*
         * Updating this Table is not ideal due to it nature and purpose. 
         * NOTE: Call Logs should not be updated because they act as legal records of calls. Being able to
         * update this table could potentially interfere with certain business ethics.
         */
        //Delete Methods
        public DataTable ReadClaims(Claims claim)
        {
            string query = string.Format(@"Select * FROM Claims WHERE ClientPolicy = {0}", claim.Cleintid);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }

}
