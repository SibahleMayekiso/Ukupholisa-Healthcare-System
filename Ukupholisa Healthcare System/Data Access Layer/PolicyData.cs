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
    class PolicyData
    {
        //Connection to a local Database that will be used by the application
        SqlConnection conn = new SqlConnection(@"Data Source=.; Initial Catalog = UkupholisaHealthcareDB; Integrated Security = SSPI");
        SqlCommand cmd;
        string queryString;

        //CRUD Operations and Methods
        //Create Methods
        //Read Methods
        #region Read Methods
        public SqlDataAdapter ReadAllPolicies()
        {
            string query = @"SELECT ClientPolicy.ClientPolicyID, ClientPolicy.ClientID,  Client.FirstName, Client.LastName, ClientPolicy.StartDate, ClientPolicy.EndDate,Product.ProductName, Product.ProductType
                FROM Client
                INNER JOIN ClientPolicy
                ON Client.ClientID = ClientPolicy.ClientID
                INNER JOIN Product
                ON ClientPolicy.Product = Product.ProductID";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return adapter;
        }
        /*
        public SqlDataAdapter ReadAllPolicies()
        {
        // Method can be used to aggregate data. Can be implemented later in the project when we use Stored Procedures
            string query = @"SELECT * FROM ClientPolicy";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        DataTable table = new DataTable();
            adapter.Fill(table);
            return adapter;
        }
        */

        public SqlDataAdapter ReadClientPolicy(Client client)
        {
            string query = string.Format(
                @"SELECT ClientPolicy.ClientPolicyID, ClientPolicy.ClientID,  Client.FirstName, Client.LastName, ClientPolicy.StartDate, ClientPolicy.EndDate,Product.ProductName, Product.ProductType
                FROM Client
                INNER JOIN ClientPolicy
                ON Client.ClientID = ClientPolicy.ClientID
                INNER JOIN Product
                ON ClientPolicy.Product = Product.ProductID
                WHERE ClientPolicy.ClientID = {0}", client.ClientID);
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
