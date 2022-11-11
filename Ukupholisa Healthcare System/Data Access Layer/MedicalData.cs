using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //Read Methods
        #region Read methods
        public DataTable ReadAllMedicalConditions()
        {
            string query = @"SELECT * FROM MedicalCondition";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable ReadAllMedicalTreatments()
        {
            string query = @"SELECT * FROM Treatment";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable ReadAllConditionTreatments()
        {
            string query = @"SELECT MedicalCondition.MedicalConditionID, MedicalCondition.MedicalConditionName, Severity, Treatment.TreatmentID, Treatment.TreatmentName, Duration
            FROM MedicalCondition
            FULL JOIN ConditionTreatment
            ON MedicalCondition.MedicalConditionID = ConditionTreatment.MedicalConditionID
            FULL JOIN Treatment
            ON ConditionTreatment.TreatmentID = Treatment.TreatmentID
            ORDER BY MedicalCondition.MedicalConditionID";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        #endregion

        //Update
        #region Update methods

        #endregion
    }
}
