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
    class ProviderData
    {
        //Connection to a local Database that will be used by the application
        SqlConnection conn = new SqlConnection(@"Data Source=.; Initial Catalog = UkupholisaHealthcareDB; Integrated Security = SSPI");
        SqlCommand cmd;
        string queryString;

        //CRUD Operations and Methods
        //Create Methods
        public string InsertProviderData(Provider provider)
        {
            string queryStateMessage = "";
            try
            {
                queryString = string.Format(
                    @"INSERT INTO Provider(ProviderName, Email, Rating, Chargerate, ProviderStatus)
                    VALUES ('{0}', '{1}', '{2}', '{3}', {4}, '{5}')", provider.Name, provider.Email, provider.Rating, provider.Rating, 
                    provider.ChargeRate, provider.Provider_Status
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
        //Read Methods
        #region Read Methods
        //public DataTable ReadAllProviders()
        //{
        //    string query = @"SELECT * FROM Provider";
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;
        //}
        public DataTable sp_ReadAllProviders()
        {
            string query = @"EXEC sp_ReadAllProviders";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        #endregion
        //Update Methods
        #region Update Methods
        public string UpdateProviderDetails(Provider provider)
        {
            string queryStateMessage = "";
            List<SqlParameter> parameterList = new List<SqlParameter>();

            try
            {
                //Parameters here
                SqlParameter providerID = new SqlParameter("@providerID", SqlDbType.Int);
                parameterList.Add(providerID);
                SqlParameter providerName = new SqlParameter("@providerName", SqlDbType.VarChar);
                parameterList.Add(providerName);
                SqlParameter email = new SqlParameter("@email", SqlDbType.VarChar);
                parameterList.Add(email);
                SqlParameter rating = new SqlParameter("@rating", SqlDbType.NVarChar);
                parameterList.Add(rating);
                SqlParameter chargeRate = new SqlParameter("@chargeRate", SqlDbType.NVarChar);
                parameterList.Add(chargeRate);

                //Setting Parameter values
                providerID.Value = provider.ProviderID;
                providerName.Value = provider.Name;
                email.Value = provider.Email;
                rating.Value = provider.Rating;
                chargeRate.Value = provider.ChargeRate;

                //Adding Parameter to SqlCommand
                parameterList.ForEach(x => { cmd.Parameters.Add(x); });

                //Executing Query
                queryString = string.Format(
                    @"UPDATE Provider
                    SET ProviderName = @providerName, Email = @email, Rating = @rating,Chargerate = @chargeRate
                    WHERE ProviderID = @providerID"
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
    }
}
