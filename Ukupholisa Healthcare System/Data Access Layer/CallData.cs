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
        //public DataTable ReadCallLogs()
        //{
        //    string query = @"SELECT * FROM CallCenter";
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;
        //}
        public DataTable sp_ReadCallLogs()
        {
            try
            {
                string query = @"EXEC sp_ReadCallLogs";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception)
            {
                throw;
                
            }
            finally
            {
                conn.Close();
            }
            
            
        }

        //public DataTable ReadClientCallLogs(Client client)
        //{
        //    string query = string.Format(@"SELECT * FROM CallCenter WHERE ClientID = {0}", client.ClientID);
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;
        //}
        public DataTable sp_ReadClientCallLogs(Client client)
        {
            try
            {
                string query = string.Format(@"EXEC sp_ReadClientCallLogs @clientID = '{0}'", client.ClientID);
                cmd= new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            
        }

        //public DataTable ReadClaims(Claims claim)
        //{
        //    string query = string.Format(
        //        @"Select ClaimID, FirstName AS 'Client Name', LastName AS 'Client Surname', CellPhoneNum, Email, ClaimeDate, ClientPolicy.ClientPolicyID, ClaimStatus
        //        FROM Claims 
        //        FULL JOIN ClientPolicy
        //        ON Claims.ClientPolicy = ClientPolicy.ClientPolicyID
        //        FULL JOIN Client
        //        ON ClientPolicy.ClientID = Client.ClientID
        //        WHERE Client.ClientID = '{0}'", claim.Clientid
        //        );
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;
        //}

        public DataTable sp_ReadClaims(Claims claim)
        {
            try
            {
                string query = string.Format(
                @"EXEC sp_ReadClaims @clientID = '{0}'", claim.Clientid
                );
                cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            
        }
        #endregion Read Methods
        //Update Methods
        /*
         * Updating this Table is not ideal due to it nature and purpose. 
         * NOTE: Call Logs should not be updated because they act as legal records of calls. Being able to
         * update this table could potentially interfere with certain business ethics.
         */

        //public string InsertClaim(Claims claim)
        //{
        //    string queryStateMessage = "";
        //    string claimStatus = claim.Status;
        //    DateTime date = DateTime.Now;
        //    int id = 0;

        //    try
        //    {
                
        //        //Executing Query
        //        queryString = string.Format(
        //            @"INSERT INTO Claims
        //            VALUES ('{0}', '{1}', '{2}', '{3}')", id ,date, claim.Policyid,claimStatus
        //            );
        //        cmd = new SqlCommand(queryString, conn);
        //        conn.Open();
        //        cmd.ExecuteNonQuery();
        //        queryStateMessage = string.Format("Update Successful");
        //    }
        //    catch (Exception e)
        //    {
        //        queryStateMessage = string.Format("An error occured and the data could not be processsed:\n{0}", e.Message);

        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return queryStateMessage;
        //}

        public string sp_InsertClaim(Claims claim)
        {
            string queryStateMessage = "";
            string claimStatus = claim.Status;
            DateTime date = DateTime.Now;
            int id = 0;

            try
            {

                //Executing Query
                queryString = string.Format(
                    @"EXEC sp_InsertClaim @claimID = '{0}', @claimeDate = '{1}', @clientPolicy = '{2}', 
                    @claimStatus = '{3}'", id, date, claim.Policyid, claimStatus
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

        //Claim Approval Function

        //public Dictionary<string, string> GetTreatmentsTable(Claims claim, Policy policy, string treatmentID)
        //{
        //    //This dictionary will be used to store the codes for the approval status for the claim as well as 
        //    //the status code for the Insert method.
        //    Dictionary<string, string> dictClaimCodes = new Dictionary<string, string>();
        //    CallData callData = new CallData();

        //    string query = string.Format(
        //        @"SELECT ClientPolicyID, Product.ProductID, Product.ProductName AS 'Product Name', Treatment.TreatmentID, Treatment.TreatmentName AS 'Treatment Name'
        //        FROM ClientPolicy
        //        FULL JOIN PolicyProduct
        //        ON ClientPolicy.ClientPolicyID = PolicyProduct.ClientPolicy
        //        FULL JOIN Product
        //        ON PolicyProduct.Product = Product.ProductID
        //        FULL JOIN TreatmentProduct
        //        ON Product.ProductID = TreatmentProduct.ProductID
        //        FULL JOIN Treatment
        //        ON TreatmentProduct.TreatmentID = Treatment.TreatmentID
        //        WHERE ClientPolicy.ClientPolicyID = '{0}'
        //        ORDER BY ProductID DESC", policy.PolicyID
        //        );
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);

        //    //string claimStatus = "DECLINED";
        //    dictClaimCodes.Add("claimStatus", "DECLINED");
        //    foreach (DataRow row in table.Rows)
        //    {
        //        if (row["TreatmentID"].ToString() == treatmentID)
        //        {
        //            dictClaimCodes["claimStatus"] = "APPROVED";
        //            //claimStatus = "APPROVED";
        //        }
        //    }
        //    string insertConfirmation = callData.InsertClaim(claim);
        //    if (dictClaimCodes["claimStatus"] == "APPROVED")
        //    {
        //        dictClaimCodes.Add("statusMessage", insertConfirmation);
        //        //string insertConfirmation = ;
        //    }
        //    //if(claimStatus == "APPROVED")
        //    //{
        //    //    //string insertConfirmation = ;
        //    //}
        //    return dictClaimCodes;
        //}

        public Dictionary<string, string> sp_GetTreatmentsTable(Claims claim, Policy policy, string treatmentID)
        {
            //This dictionary will be used to store the codes for the approval status for the claim as well as 
            //the status code for the Insert method.
            Dictionary<string, string> dictClaimCodes = new Dictionary<string, string>();
            CallData callData = new CallData();

            try
            {
                string query = string.Format(
                @"EXEC sp_GetTreatmentsTable @clientPolicyID = '{0}'", policy.PolicyID
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
                string insertConfirmation = callData.sp_InsertClaim(claim);
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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
                        
        }
       

    }

}
