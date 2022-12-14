using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
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

        public DataTable ReadClaims(Claims claim)
        {
            string query = string.Format(
                @"Select ClaimID, FirstName AS 'Client Name', LastName AS 'Client Surname', CellPhoneNum, Email, ClaimeDate, ClientPolicy.ClientPolicyID, ClaimStatus
                FROM Claims 
                FULL JOIN ClientPolicy
                ON Claims.ClientPolicy = ClientPolicy.ClientPolicyID
                FULL JOIN Client
                ON ClientPolicy.ClientID = Client.ClientID
                WHERE Client.ClientID = '{0}'", claim.Clientid
                );
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

        public string InsertClaim(Claims claim)
        {
            string queryStateMessage = "";
            string claimStatus = claim.Status;
            DateTime date = DateTime.Now;
            int id = 0;

            try
            {
                
                //Executing Query
                queryString = string.Format(
                    @"INSERT INTO Claims
                    VALUES ('{0}', '{1}', '{2}', '{3}')", id ,date, claim.Policyid,claimStatus
                    );
                cmd = new SqlCommand(queryString, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                queryStateMessage = string.Format("Update Successful");
            }
            catch (Exception e)
            {
                queryStateMessage = string.Format("An error occured and the data could not be processsed:\n{0}", e.Message);

            }
            finally
            {
                conn.Close();
            }
            return queryStateMessage;
        }
        //Delete Methods
        
        //Claim Approval Function
        public Dictionary<string, string> GetTreatmentsTable(Claims claim, Policy policy, string treatmentID)
        {
            //This dictionary will be used to store the codes for the approval status for the claim as well as 
            //the status code for the Insert method.
            Dictionary<string, string> dictClaimCodes = new Dictionary<string, string>();
            CallData callData = new CallData();

            string query = string.Format(
                @"SELECT ClientPolicyID, Product.ProductID, Product.ProductName AS 'Product Name', Treatment.TreatmentID, Treatment.TreatmentName AS 'Treatment Name'
                FROM ClientPolicy
                FULL JOIN PolicyProduct
                ON ClientPolicy.ClientPolicyID = PolicyProduct.ClientPolicy
                FULL JOIN Product
                ON PolicyProduct.Product = Product.ProductID
                FULL JOIN TreatmentProduct
                ON Product.ProductID = TreatmentProduct.ProductID
                FULL JOIN Treatment
                ON TreatmentProduct.TreatmentID = Treatment.TreatmentID
                WHERE ClientPolicy.ClientPolicyID = '{0}'
                ORDER BY ProductID DESC", policy.PolicyID
                );
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            //string claimStatus = "DECLINED";
            dictClaimCodes.Add("claimStatus", "DECLINED");
            foreach (DataRow row in table.Rows)
            {
                if (row["TreatmentID"].ToString() == treatmentID)
                {
                    dictClaimCodes["claimStatus"] = "APPROVED";
                    //claimStatus = "APPROVED";
                }
            }
            string insertConfirmation = callData.InsertClaim(claim);
            if (dictClaimCodes["claimStatus"] == "APPROVED")
            {
                dictClaimCodes.Add("statusMessage", insertConfirmation);
                //string insertConfirmation = ;
            }
            //if(claimStatus == "APPROVED")
            //{
            //    //string insertConfirmation = ;
            //}
            return dictClaimCodes;
        }
        //All the datta adding code
        public string InsertData(string s1, string s2, int s3, string s4,string s5)
        {
            string queryStateMessage = "";
            try
            {
                queryString = string.Format(
                    @"INSERT INTO Client(FirstName, LastName, CellPhoneNum)
                    VALUES ('{0}', '{1}', '{2}')", s1, s2, s3
                    );
                queryString = string.Format(
                    @"INSERT INTO Product(ProductName)
                    VALUES ('{0}')", s4);
                queryString = string.Format(
                    @"INSERT INTO MedicalCondition(MedicalConditionName)
                    VALUES ('{0}')", s5);
                cmd = new SqlCommand(queryString, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                queryStateMessage = string.Format("Update Successful");
            }
            catch (Exception e)
            {
                queryStateMessage = string.Format("An error occured and the data could not be processsed:\n{0}", e.Message);
            }
            finally
            {
                conn.Close();
            }
            return queryStateMessage;

        }

    }

}
