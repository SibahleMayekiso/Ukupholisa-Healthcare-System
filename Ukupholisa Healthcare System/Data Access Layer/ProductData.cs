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
    class ProductData
    {
        //Connection to a local Database that will be used by the application
        SqlConnection conn = new SqlConnection(@"Data Source=.; Initial Catalog = UkupholisaHealthcareDB; Integrated Security = SSPI");
        SqlCommand cmd;
        string queryString;

        //CRUD Operations and Methods
        //Create Methods
        public string InsertProductData(Product product)
        {
            string queryStateMessage = "";

            string dateYearStart, dateMonthStart, dateDayStart;
            string dateYearEnd, dateMonthEnd, dateDayEnd;

            dateYearStart = product.DateStart.Year.ToString();
            dateMonthStart = product.DateStart.Month.ToString();
            dateDayStart = product.DateStart.Day.ToString();

            dateYearEnd = product.DateEnd.Year.ToString();
            dateMonthEnd = product.DateEnd.Month.ToString();
            dateDayEnd = product.DateEnd.Day.ToString();
            try
            {
                queryString = string.Format(
                    @"INSERT INTO Product(ProductName, ProductType, MaxDependents, StartDate, EndDate)
                    VALUES ('{0}', '{1}', {2}, '{3}', '{4}')", product.ProductName, product.ProductType, product.MaxDependents,
                    string.Concat(dateYearStart, dateMonthStart, dateDayStart), string.Concat(dateYearEnd, dateMonthEnd, dateDayEnd)
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
        public DataTable ReadAllProducts()
        {
            string query = @"SELECT * FROM Product";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        #endregion
        //Update Methods
        #region Update Methods
        public string UpdateProductDetails(Product product)
        {
            string queryStateMessage = "";
            List<SqlParameter> parameterList = new List<SqlParameter>();

            try
            {
                //Parameters here
                SqlParameter productID = new SqlParameter("@productID", SqlDbType.Int);
                parameterList.Add(productID);
                SqlParameter prodName = new SqlParameter("@productName", SqlDbType.VarChar);
                parameterList.Add(prodName);
                SqlParameter prodType = new SqlParameter("@prodType", SqlDbType.VarChar);
                parameterList.Add(prodType);
                SqlParameter maxDependents = new SqlParameter("@maxDependents", SqlDbType.NVarChar);
                parameterList.Add(maxDependents);

                //Setting Parameter values
                productID.Value = product.ProdutID;
                prodName.Value = product.ProductName;
                prodType.Value = product.ProductType;
                maxDependents.Value = product.MaxDependents;

                //Adding Parameter to SqlCommand
                parameterList.ForEach(x => { cmd.Parameters.Add(x); });

                //Executing Query
                queryString = string.Format(
                    @"UPDATE Product
                    SET ProductName = @productName, ProductType = @prodType, MaxDependents = @maxDependents
                    WHERE ProductID = @productID"
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

        public string UpdateProductAvailability(Product product)
        {
            string queryStateMessage = "";
            List<SqlParameter> parameterList = new List<SqlParameter>();

            try
            {
                queryString = string.Format(
                    @"UPDATE Product
                    SET StartDate = @start, EndDate = @end
                    WHERE ProductID = @productID"
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
