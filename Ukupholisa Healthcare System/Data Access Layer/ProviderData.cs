using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare_System.Data_Access_Layer
{
    class ProviderData
    {
        //Connection to a local Database that will be used by the application
        SqlConnection conn = new SqlConnection(@"Data Source=.; Initial Catalog = UkupholisaHealthcareDB; Integrated Security = SSPI");
        SqlCommand cmd;
        string queryString;

        //CRUD Operations and Methods
        //Create Methods
        //Read Methods
        #region Read Methods
        public SqlDataAdapter ReadAllProviders()
        {
            string query = @"SELECT * FROM Provider";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            return adapter;
        }
        #endregion
        //Update Methods
        //Delete Methods
    }
}
