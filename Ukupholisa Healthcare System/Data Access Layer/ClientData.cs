using System;
using System.Collections.Generic;
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
            return adapter;
        }

        public SqlDataAdapter ReadClientDetails(Client client)
        {
            string query = string.Format(@"SELECT * FROM Client WHERE ClientID = {0}", client.ClientID);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
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
            return adapter;
        }
        #endregion
        //Update Methods
        //Delete Methods
    }
}
