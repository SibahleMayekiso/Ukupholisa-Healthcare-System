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

        public Product()
        {

        }

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

        public BindingSource GetProductReport()
        {
            PolicyData policyData = new PolicyData();
            BindingSource source = new BindingSource();
            source.DataSource = policyData.GetPerformanceReport();
            return source;
        }
        public BindingSource GetProductReportByDate(DateTime start, DateTime end)
        {
            PolicyData policyData = new PolicyData();
            BindingSource source = new BindingSource();
            source.DataSource = policyData.GetPerformanceReportByDate(start, end);
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
    }
}
