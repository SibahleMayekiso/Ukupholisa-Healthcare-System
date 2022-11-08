using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukupholisa_Healthcare_System.Data_Access_Layer;

namespace Ukupholisa_Healthcare_System.Business_Logic_Layer
{
    //This is a class for the products (policies) offered by Ukupholisa Healthcare
    class Product
    {
        private int produtID, maxDependents;
        private string productName, productType;

        public Product(int produtID, int maxDependents, string productName, string productType)
        {
            this.produtID = produtID;
            this.maxDependents = maxDependents;
            this.productName = productName;
            this.productType = productType;
        }

        public int ProdutID { get => produtID; set => produtID = value; }
        public int MaxDependents { get => maxDependents; set => maxDependents = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string ProductType { get => productType; set => productType = value; }

        //CRUD Operations

        //Read Methods
        #region Read
        public BindingSource GetProductPoliciesTable()
        {
            ProductData productData = new ProductData();
            BindingSource source = new BindingSource();
            source.DataSource = productData.ReadAllProducts();
            return source;
        }
        #endregion
        //Update Methods
        #region Update
        public void UpdateProductPoliciesDetails(Product product)
        {
            ProductData productData = new ProductData();
            productData.UpdateProductDetails(product);
        }

        public void UpdateProductStatus(Product product)
        {
            ProductData productData = new ProductData();
            productData.UpdateProductDetails(product);
        }
        #endregion
        public string AddProductValidation(string pname, string type, DateTime startDate, bool unlimited, DateTime endDate)
        {
            if (pname == null | type == null | startDate == null | unlimited == false | endDate == null)
            {
                return ("Please Fill in all Fields");
            }
            else
            {
                return ("Added Succesfully");
            }


        }
        public string UpdateProductValidation(int ProductID, DateTime startDate, bool unlimited, DateTime endDate)
        {
            if (String.IsNullOrEmpty(ProductID.ToString()) | startDate == null | unlimited == false | endDate == null)
            {
                return ("Please Fill in all Fields");
            }
            else
            {
                return ("Updated Succesfully");
            }


        }
    }
}
