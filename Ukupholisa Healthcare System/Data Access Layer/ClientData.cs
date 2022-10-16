﻿using System;
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
        //Create Methods
        //Read Methods
        #region Read Methods
        public SqlDataAdapter ReadAllClients()
        {
            string query = @"SELECT * FROM Client";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return adapter;
        }

        public SqlDataAdapter ReadClientDetails(Client client)
        {
            string query = string.Format(@"SELECT * FROM Client WHERE ClientID = {0}", client.ClientID);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return adapter;
        }

        public SqlDataAdapter ReadClientDependents(Client client)
        {
            string query = string.Format(
                @"SELECT Client.ClientID, ClientDependent.DependentID, ClientDependent.FirstName, ClientDependent.LastName
                , ClientDependent.RelationToClient, ClientDependent.CellPhoneNum, ClientDependent.Email
                FROM Client
                INNER JOIN ClientDependent
                ON Client.ClientID = ClientDependent.ClientID
                WHERE ClientDependent.ClientID = {0}", client.ClientID);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return adapter;
        }
        #endregion
        //Update Methods
        #region Update Methods
        public string UpdateClientDetails(Client client)
        {
            string queryStateMessage = "";
            List<SqlParameter> parameterList = new List<SqlParameter>();

            try
            {
                //Parameters here
                SqlParameter clientID = new SqlParameter("@clientID", SqlDbType.Int);
                parameterList.Add(clientID);
                SqlParameter firstname = new SqlParameter("@firstname", SqlDbType.VarChar);
                parameterList.Add(firstname);
                SqlParameter lastname = new SqlParameter("@surname", SqlDbType.VarChar);
                parameterList.Add(lastname);
                SqlParameter cellNum = new SqlParameter("@cellNo", SqlDbType.NVarChar);
                parameterList.Add(cellNum);
                SqlParameter email = new SqlParameter("@email", SqlDbType.NVarChar);
                parameterList.Add(email);

                //Setting Parameter values
                clientID.Value = client.ClientID;
                firstname.Value = client.FirstName;
                lastname.Value = client.Lastname;
                cellNum.Value = client.CellphoneNum;
                email.Value = client.Email;

                //Adding Parameter to SqlCommand
                parameterList.ForEach(x => { cmd.Parameters.Add(x); });
                
                //Executing Query
                queryString = string.Format(
                    @"UPDATE Client
                    SET FirstName = @firstname, LastName = @surname, CellPhoneNum = @cellNo, Email = @email
                    WHERE ClientID = @clientID"
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
