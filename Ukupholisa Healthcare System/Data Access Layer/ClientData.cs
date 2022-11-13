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
    class ClientData
    {
        //Connection to a local Database that will be used by the application
        SqlConnection conn = new SqlConnection(@"Data Source=.; Initial Catalog = UkupholisaHealthcareDB; Integrated Security = SSPI");
        SqlCommand cmd;
        string queryString;

        //CRUD Operations and Methods
        //Create/Insert Methods
        public string InsertClientData(Client client)
        {
            string queryStateMessage = "";

            #region Client ID Checker
            //This section will check to see if there is an already existing Policy ID int the database
            DataTable clientDataTable = sp_ReadAllClients();
            bool bFound = false;
            string uniqueID = "";

            //while (bFound == false)
            //{
            //    uniqueID = GenerateClientID(client);

            //    foreach (DataRow row in clientDataTable.Rows)
            //    {
            //        uniqueID = GenerateClientID(client);
            //        if (row["ClientID"].ToString() == uniqueID)
            //        {
            //            bFound = true;
            //        }
            //    }
            //}

            foreach (DataRow row in clientDataTable.Rows)
            {
                uniqueID = GenerateClientID(client);
                if (row["ClientID"].ToString() == uniqueID)
                {
                    bFound = true;
                }
            }
            #endregion

            try
            {
                queryString = string.Format(
                    @"INSERT INTO Client(FirstName, LastName, CellPhoneNum, Email, ClientID)
                    VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", client.FirstName, client.Lastname, client.CellphoneNum, client.Email, client.ClientID
                    );
                //queryString = string.Format(
                //    @"INSERT INTO Region(RegionID, Suburb)
                //    VALUES ('{0}', '{1}')", s5, s6
                //    );
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
        //public DataTable ReadAllClients()
        //{
        //    string query = @"SELECT * FROM Client";
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;
        //}
        public DataTable sp_ReadAllClients()
        {
            try
            {
                string query = @"EXEC sp_ReadAllClients";
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

        //public DataTable ReadClientDetails(Client client)
        //{
        //    string query = string.Format(@"SELECT * FROM Client WHERE ClientID = {0}", client.ClientID);
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;
        //}

        public DataTable sp_ReadClientDetails(Client client)
        {
            try
            {
                string query = string.Format(@"EXEC sp_ReadClientDetails @clientID = '{0}'", client.ClientID);
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

        //public DataTable ReadClientDependents(Client client)
        //{
        //    string query = string.Format(
        //        @"SELECT Client.ClientID, ClientDependent.DependentID, ClientDependent.FirstName, ClientDependent.LastName
        //        , ClientDependent.RelationToClient, ClientDependent.CellPhoneNum, ClientDependent.Email
        //        FROM Client
        //        INNER JOIN ClientDependent
        //        ON Client.ClientID = ClientDependent.ClientID
        //        WHERE ClientDependent.ClientID = '{0}'", client.ClientID);
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;
        //}
        public DataTable ReadClientDependents(Client client)
        {
            try
            {
                string query = string.Format(
                @"EXEC sp_ReadClientDependents @clientID = '{0}'", client.ClientID);
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
        //Update Methods
        #region Update Methods
        //public string UpdateClientDetails(Client client)
        //{
        //    string queryStateMessage = "";
        //    List<SqlParameter> parameterList = new List<SqlParameter>();

        //    try
        //    {
        //        //Parameters here
        //        SqlParameter clientID = new SqlParameter("@clientID", SqlDbType.Int);
        //        parameterList.Add(clientID);
        //        SqlParameter firstname = new SqlParameter("@firstname", SqlDbType.VarChar);
        //        parameterList.Add(firstname);
        //        SqlParameter lastname = new SqlParameter("@surname", SqlDbType.VarChar);
        //        parameterList.Add(lastname);
        //        SqlParameter cellNum = new SqlParameter("@cellNo", SqlDbType.NVarChar);
        //        parameterList.Add(cellNum);
        //        SqlParameter email = new SqlParameter("@email", SqlDbType.NVarChar);
        //        parameterList.Add(email);

        //        //Setting Parameter values
        //        clientID.Value = client.ClientID;
        //        firstname.Value = client.FirstName;
        //        lastname.Value = client.Lastname;
        //        cellNum.Value = client.CellphoneNum;
        //        email.Value = client.Email;

        //        //Adding Parameter to SqlCommand
        //        parameterList.ForEach(x => { cmd.Parameters.Add(x); });

        //        //Executing Query
        //        queryString = string.Format(
        //            @"UPDATE Client
        //            SET FirstName = @firstname, LastName = @surname, CellPhoneNum = @cellNo, Email = @email
        //            WHERE ClientID = @clientID"
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

        public string UpdateClientDetails(Client client)
        {
            string queryStateMessage = "";

            try
            { 
                //Executing Query
                queryString = string.Format(
                    @"EXEC sp_UpdateClientDetails @clientID = '', @firstname = '', @surname = '', @cellNo = '', @email = ''",
                    client.ClientID, client.FirstName, client.Lastname, client.CellphoneNum, client.Email
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

        //Cleint ID Generation
        public string GenerateClientID(Client client)
        {
            Random random = new Random();
            int i = random.Next(99999999);
            int Length = i.ToString().Length;
            string Number = i.ToString();
            string[] Letters = { "G", "H", "j", "K", "L" };
            int l = random.Next(4);
            string Let = Letters[l];
            while (Length != 8)
            {
                Number = string.Concat("0", Number);
            }
            string Complete = Let + Number;
            return Complete;

           
        }
}
}
