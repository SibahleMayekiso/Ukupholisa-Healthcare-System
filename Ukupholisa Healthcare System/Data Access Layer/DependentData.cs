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
    class DependentData
    {
        //Connection to a local Database that will be used by the application
        SqlConnection conn = new SqlConnection(@"Data Source=.; Initial Catalog = UkupholisaHealthcareDB; Integrated Security = SSPI");
        SqlCommand cmd;
        string queryString;

        //CRUD Operations and Methods
        //Create Methods
        //Read Methods
        #region Read Methods
        public SqlDataAdapter ReadAllDependents()
        {
            string query = @"SELECT * FROM ClientDependent";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return adapter;
        }

        public SqlDataAdapter ReadDependentDetails(Dependent dependent)
        {
            string query = string.Format(@"SELECT * FROM ClientDependent WHERE DependentID = {0}", dependent.DependentID);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return adapter;
        }
        #endregion
        //Update Methods
        //Delete Methods
    }
}
