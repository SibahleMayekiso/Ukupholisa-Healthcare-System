using System;
using System.Collections;
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
        #region CRUD Operations
        //Create Methods
        //Read Methods
        #region Read Methods
        public DataTable ReadAllPolicies()
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
            return table;
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

        public DataTable ReadClientPolicy(Client client)
        {
            string query = string.Format(
                "SELECT ClientPolicy.ClientPolicyID, ClientPolicy.ClientID,  Client.FirstName, Client.LastName, ClientPolicy.StartDate, ClientPolicy.EndDate,Product.ProductName, Product.ProductType"
                 + "FROM Client" +
                "INNER JOIN ClientPolicy" +
                "ON Client.ClientID = ClientPolicy.ClientID" +
                "INNER JOIN Product" +
                "ON ClientPolicy.Product = Product.ProductID" +
                "WHERE ClientPolicy.ClientID = " + client.ClientID );
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        #endregion
        //Update Methods
        #region Update Methods
        public string UpdateClientPolicyDetails(Policy policy)
        {
            string queryStateMessage = "";
            List<SqlParameter> parameterList = new List<SqlParameter>();

            try
            {
                //Parameters here
                SqlParameter policyID = new SqlParameter("@policyID", SqlDbType.Int);
                parameterList.Add(policyID);
                SqlParameter startDate = new SqlParameter("@startdate", SqlDbType.VarChar);
                parameterList.Add(startDate);
                SqlParameter endDate = new SqlParameter("@enddate", SqlDbType.VarChar);
                parameterList.Add(endDate);
                SqlParameter product = new SqlParameter("@productID", SqlDbType.NVarChar);
                parameterList.Add(product);

                //Setting Parameter values
                policyID.Value = policy.PolicyID;
                startDate.Value = policy.StartDate;
                endDate.Value = policy.EndDate;
                product.Value = policy.ProductID;

                //Adding Parameter to SqlCommand
                parameterList.ForEach(x => { cmd.Parameters.Add(x); });

                //Executing Query
                queryString = string.Format(
                    @"UPDATE ClientPolicy
                    SET StartDate = @startdate, EndDate = @enddate, Product = @productID
                    WHERE ClientPolicyID = @policyID"
                    );
                cmd = new SqlCommand(queryString, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                queryStateMessage = string.Format("An error occured:\n{0}", e.Message);

            }
            finally
            {
                queryStateMessage = string.Format("Update Successful");
                conn.Close();
            }
            return queryStateMessage;
        }

        #endregion
        //Delete Methods
        #endregion

        public DataTable GetPerformanceReport()
        {
            //This method will generate a report on all product claims since the system was created
            string query = String.Format(
                @"SELECT Product.ProductID AS 'Product ID', Product.ProductName AS 'Product Name', COUNT(Product.ProductID) AS 'Total Claims'
                FROM Claims
                FULL JOIN ClientPolicy
                ON Claims.ClientPolicy = ClientPolicy.ClientPolicyID
                FULL JOIN PolicyProduct
                ON ClientPolicy.ClientPolicyID = PolicyProduct.ClientPolicy
                FULL JOIN Product
                ON PolicyProduct.Product = Product.ProductID
                GROUP BY Product.ProductID, Product.ProductName
                ORDER BY COUNT(Product.ProductID) DESC"
                );
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable GetPerformanceReportByDate(DateTime start, DateTime end)
        {
            string dateYearStart, dateMonthStart, dateDayStart;
            string dateYearEnd, dateMonthEnd, dateDayEnd;

            dateYearStart = start.Year.ToString();
            dateMonthStart = start.Month.ToString();
            dateDayStart = start.Day.ToString();

            dateYearEnd = end.Year.ToString();
            dateMonthEnd = end.Month.ToString();
            dateDayEnd = end.Day.ToString();
            //This method will generate a report on all product claims since the system was created
            string query = String.Format(
                @"SELECT Product.ProductID AS 'Product ID', Product.ProductName AS 'Product Name', COUNT(Product.ProductID) AS 'Total Claims'
                FROM Claims
                FULL JOIN ClientPolicy
                ON Claims.ClientPolicy = ClientPolicy.ClientPolicyID
                FULL JOIN PolicyProduct
                ON ClientPolicy.ClientPolicyID = PolicyProduct.ClientPolicy
                FULL JOIN Product
                ON PolicyProduct.Product = Product.ProductID
                WHERE ClaimeDate < {0} AND ClaimeDate > {1}
                GROUP BY Product.ProductID, Product.ProductName
                ORDER BY COUNT(Product.ProductID) DESC
                ", string.Concat(dateYearEnd,dateMonthEnd,dateDayEnd), string.Concat(dateYearStart, dateMonthStart, dateDayStart)/*end, start*/
                );
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //Policy ID Generation
        public string GeneratePolicyID(Policy policy)
        {
            int Year = Convert.ToInt32(policy.StartDate.Year);
            string[] Letters = { "A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] Importatnt = { "A", "B", "C", "D" };
            Random ran = new Random();
            int l = ran.Next(23);
            int i = ran.Next(999999);
            int k = ran.Next(3);
            int len = Convert.ToString(i).Length;
            string Lett = i.ToString();
            string j = Letters[l];
            string Imp = Importatnt[k];
            while (len != 6)
            {
                Lett = "0" + Lett; 
            }
            string complete = Year + j + k + Lett;
            return complete;

            
        }
    }
}
