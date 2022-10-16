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
    class HospitalData
    {
        //Connection to a local Database that will be used by the application
        SqlConnection conn = new SqlConnection(@"Data Source=.; Initial Catalog = UkupholisaHealthcareDB; Integrated Security = SSPI");
        SqlCommand cmd;
        string queryString;

        //CRUD Operations and Methods
        //Create Methods
        //Read Methods
        #region Read Methods
        public SqlDataAdapter ReadAllHospitals()
        {
            //NOTE: We need to add a Name column in the Database table, Hospital - RESOLVED
            string query = @"SELECT Hospital.HospitalID, Hospital.HospitalName, Hospital.Street, Region.Suburb
            , Region.City, Region.Region
            FROM Hospital
            RIGHT JOIN Region
            ON Hospital.Region = Region.RegionID";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return adapter;
        }

        public SqlDataAdapter ReadHospitalDetails(Hospital hospital)
        {
            string query = string.Format(
                @"SELECT Hospital.HospitalID, Hospital.HospitalName, Hospital.Street, Region.Suburb
                , Region.City, Region.Region
                FROM Hospital
                RIGHT JOIN Region
                ON Hospital.Region = Region.RegionID
                WHERE HospitalID = {0}", hospital.HospitalID);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return adapter;
        }
        #endregion
        //Update Methods
        #region Update Methods
        public string UpdateHospitalDetails(Hospital hospital)
        {
            string queryStateMessage = "";
            List<SqlParameter> parameterList = new List<SqlParameter>();

            try
            {
                //Parameters here
                SqlParameter hospitalID = new SqlParameter("@hospitalID", SqlDbType.Int);
                parameterList.Add(hospitalID);
                SqlParameter hospitalname = new SqlParameter("@hospitalname", SqlDbType.VarChar);
                parameterList.Add(hospitalname);
                SqlParameter street = new SqlParameter("@address", SqlDbType.VarChar);
                parameterList.Add(street);
                SqlParameter region = new SqlParameter("@regionId", SqlDbType.Int);
                parameterList.Add(region);

                //Setting Parameter values
                hospitalID.Value = hospital.HospitalID;
                hospitalname.Value = hospital.HospitalName;
                street.Value = hospital.Street;
                region.Value = hospital.RegionID;

                //Adding Parameter to SqlCommand
                parameterList.ForEach(x => { cmd.Parameters.Add(x); });

                //Executing Query
                queryString = string.Format(
                    @"UPDATE Hospital
                    SET Street = @address, HospitalName = @hospitalname, Region = @regionId
                    WHERE HospitalID = @hospitalID"
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
