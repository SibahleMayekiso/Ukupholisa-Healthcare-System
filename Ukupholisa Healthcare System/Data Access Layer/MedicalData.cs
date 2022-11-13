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
    class MedicalData
    {
        //Connection to a local Database that will be used by the application
        SqlConnection conn = new SqlConnection(@"Data Source=.; Initial Catalog = UkupholisaHealthcareDB; Integrated Security = SSPI");
        SqlCommand cmd;
        string queryString;

        //CRUD Operations and Methods
        //Create Methods
        public string InsertConditionData(MedCondition medical)
        {
            string queryStateMessage = "";
            try
            {
                queryString = string.Format(
                    @"INSERT INTO MedicalCondition(MedicalConditionName, Severity)
                    VALUES ('{0}', '{1}')", medical.ConditionName, medical.Severity
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
        public string InsertTreatmentData(Treatment treatment)
        {
            string queryStateMessage = "";
            try
            {
                queryString = string.Format(
                    @"INSERT INTO Treatment(Duration, TreatmentName)
                    VALUES ('{0}')", treatment.Duration, treatment.TreatmentName
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
        #region Read methods
        //public DataTable ReadAllMedicalConditions()
        //{
        //    string query = @"SELECT * FROM MedicalCondition";
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;
        //}
        public DataTable sp_ReadAllMedicalConditions()
        {
            try
            {
                string query = @"EXEC sp_ReadAllMedicalConditions";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                cmd = new SqlCommand(query, conn);
                conn.Open();
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

        //public DataTable ReadAllMedicalTreatments()
        //{
        //    string query = @"SELECT * FROM Treatment";
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;
        //}
        public DataTable sp_ReadAllMedicalTreatments()
        {
            try
            {
                string query = @"EXEC sp_ReadAllMedicalTreatments";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                cmd = new SqlCommand(query, conn);
                conn.Open();
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

        //public DataTable ReadAllConditionTreatments()
        //{
        //    string query = @"SELECT MedicalCondition.MedicalConditionID, MedicalCondition.MedicalConditionName, Severity, Treatment.TreatmentID, Treatment.TreatmentName, Duration
        //    FROM MedicalCondition
        //    FULL JOIN ConditionTreatment
        //    ON MedicalCondition.MedicalConditionID = ConditionTreatment.MedicalConditionID
        //    FULL JOIN Treatment
        //    ON ConditionTreatment.TreatmentID = Treatment.TreatmentID
        //    ORDER BY MedicalCondition.MedicalConditionID";
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;
        //}
        public DataTable sp_ReadAllConditionTreatments()
        {
            try
            {
                string query = @"EXEC sp_ReadAllConditionTreatments";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                cmd = new SqlCommand(query, conn);
                conn.Open();
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
        #endregion

        //Update
        #region Update methods

        #endregion
    }
}
