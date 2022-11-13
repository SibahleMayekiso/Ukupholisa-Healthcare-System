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
        //public SqlDataAdapter ReadAllDependents()
        //{
        //    string query = @"SELECT * FROM ClientDependent";
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return adapter;
        //}

        public SqlDataAdapter sp_ReadAllDependents()
        {
            try
            {
                string query = @"EXEC sp_ReadAllDependents";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                cmd = new SqlCommand(query, conn);
                conn.Open();
                DataTable table = new DataTable();
                adapter.Fill(table);
                return adapter;
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

        //public SqlDataAdapter ReadDependentDetails(Dependent dependent)
        //{
        //    string query = string.Format(@"SELECT * FROM ClientDependent WHERE DependentID = {0}", dependent.DependentID);
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return adapter;
        //}
        public SqlDataAdapter sp_ReadDependentDetails(Dependent dependent)
        {
            try
            {
                string query = string.Format(@"sp_ReadDependentDetails @dependentID = '{0}'", dependent.DependentID);
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                cmd = new SqlCommand(query, conn);
                conn.Open();
                DataTable table = new DataTable();
                adapter.Fill(table);
                return adapter;
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
        //Update Methods
        #region Update Methods
        //public string UpdateDependentDetails(Dependent dependent)
        //{
        //    string queryStateMessage = "";
        //    List<SqlParameter> parameterList = new List<SqlParameter>();

        //    try
        //    {
        //        //Parameters here
        //        SqlParameter dependentID = new SqlParameter("@dependentID", SqlDbType.Int);
        //        parameterList.Add(dependentID);
        //        SqlParameter firstname = new SqlParameter("@firstname", SqlDbType.NVarChar);
        //        parameterList.Add(firstname);
        //        SqlParameter lastname = new SqlParameter("@surname", SqlDbType.NVarChar);
        //        parameterList.Add(lastname);
        //        SqlParameter cellNum = new SqlParameter("@cellNo", SqlDbType.VarChar);
        //        parameterList.Add(cellNum);
        //        SqlParameter email = new SqlParameter("@email", SqlDbType.NVarChar);
        //        parameterList.Add(email);
        //        SqlParameter relation = new SqlParameter("@relation", SqlDbType.VarChar);
        //        parameterList.Add(relation);
        //        SqlParameter coverage = new SqlParameter("@perc", SqlDbType.Int);
        //        parameterList.Add(coverage);

        //        //Setting Parameter values
        //        dependentID.Value = dependent.DependentID;
        //        firstname.Value = dependent.FirstName;
        //        lastname.Value = dependent.Lastname;
        //        cellNum.Value = dependent.CellphoneNum;
        //        email.Value = dependent.Email;
        //        relation.Value = dependent.RelationToClient;
        //        coverage.Value = dependent.CoveragePercentage;

        //        //Adding Parameter to SqlCommand
        //        parameterList.ForEach(x => { cmd.Parameters.Add(x); });

        //        //Executing Query
        //        queryString = string.Format(
        //            @"UPDATE ClientDependent
        //            SET FirstName = @name, LastName = @surname, CellPhoneNum = @cellno, Email = @email, RelationToClient = @relation, CoveragePercentage = @perc
        //            WHERE DependentID = @dependentID"
        //            );
        //        cmd = new SqlCommand(queryString, conn);
        //        conn.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        queryStateMessage = string.Format("An error occured:\n{0}", e.Message);

        //    }
        //    finally
        //    {
        //        queryStateMessage = string.Format("Update Successful");
        //        conn.Close();
        //    }
        //    return queryStateMessage;
        //}

        public string sp_UpdateDependentDetails(Dependent dependent)
        {
            string queryStateMessage = "";

            try
            {
                
                //Executing Query
                queryString = string.Format(
                    @"EXEC sp_UpdateDependentDetails @dependentID = '{0}', @name = '{1}', @surname = '{2}', 
                    @cellno = '{3}', @email = '{4}', @relation = '{5}', @perc = '{6}'",
                    dependent.DependentID, dependent.FirstName, dependent.Lastname, dependent.CellphoneNum,
                    dependent.Email, dependent.RelationToClient, dependent.CoveragePercentage
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

        //public string UpdateDependentClient(Dependent dependent)
        //{
        //    //Method is used to change a dependent's client/policy holder to someone else (in the case of family seperation )
        //    string queryStateMessage = "";
        //    List<SqlParameter> parameterList = new List<SqlParameter>();

        //    try
        //    {
        //        //Parameters here
        //        SqlParameter dependentID = new SqlParameter("@dependentID", SqlDbType.Int);
        //        parameterList.Add(dependentID);
        //        SqlParameter clientID = new SqlParameter("@clientID", SqlDbType.NVarChar);
        //        parameterList.Add(clientID);

        //        //Setting Parameter values
        //        dependentID.Value = dependent.DependentID;
        //        clientID.Value = dependent.ClientID;

        //        //Adding Parameter to SqlCommand
        //        parameterList.ForEach(x => { cmd.Parameters.Add(x); });

        //        //Executing Query
        //        queryString = string.Format(
        //            @"UPDATE ClientDependent
        //            SET ClientID = @clintID
        //            WHERE DependentID = @dependentID"
        //            );
        //        cmd = new SqlCommand(queryString, conn);
        //        conn.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        queryStateMessage = string.Format("An error occured:\n{0}", e.Message);

        //    }
        //    finally
        //    {
        //        queryStateMessage = string.Format("Update Successful");
        //        conn.Close();
        //    }
        //    return queryStateMessage;
        //}

        public string sp_UpdateDependentClient(Dependent dependent)
        {
            //Method is used to change a dependent's client/policy holder to someone else (in the case of family seperation )
            string queryStateMessage = "";
            List<SqlParameter> parameterList = new List<SqlParameter>();

            try
            {
                //Parameters here
                SqlParameter dependentID = new SqlParameter("@dependentID", SqlDbType.Int);
                parameterList.Add(dependentID);
                SqlParameter clientID = new SqlParameter("@clientID", SqlDbType.NVarChar);
                parameterList.Add(clientID);

                //Setting Parameter values
                dependentID.Value = dependent.DependentID;
                clientID.Value = dependent.ClientID;

                //Adding Parameter to SqlCommand
                parameterList.ForEach(x => { cmd.Parameters.Add(x); });

                //Executing Query
                queryString = string.Format(
                    @"EXEC sp_UpdateDependentClient @clientID = '{0}', @dependentID = '{1}'",
                    dependent.ClientID, dependent.DependentID
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
