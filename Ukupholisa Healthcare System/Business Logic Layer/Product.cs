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
        private DateTime dateStart, dateEnd;

        public Product()
        {

        }

        public Product(int produtID, int maxDependents, string productName, string productType, DateTime dateStart, DateTime dateEnd)
        {
            this.produtID = produtID;
            this.maxDependents = maxDependents;
            this.productName = productName;
            this.productType = productType;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
        }

        public int ProdutID { get => produtID; set => produtID = value; }
        public int MaxDependents { get => maxDependents; set => maxDependents = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string ProductType { get => productType; set => productType = value; }
        public DateTime DateStart { get => dateStart; set => dateStart = value; }
        public DateTime DateEnd { get => dateEnd; set => dateEnd = value; }

        //CRUD Operations
        //Insert Methods
        public string InsertProductDetails(Product product)
        {
            ProductData productData = new ProductData();
            return productData.InsertProductData(product);
        }
        //Read Methods
        #region Read
        public BindingSource GetProductPoliciesTable()
        {
            ProductData productData = new ProductData();
            BindingSource source = new BindingSource();
            source.DataSource = productData.sp_ReadAllProducts();
            return source;
        }

        public BindingSource GetProductReport()
        {
            PolicyData policyData = new PolicyData();
            BindingSource source = new BindingSource();
            source.DataSource = policyData.sp_GetPerformanceReport();
            return source;
        }
        public BindingSource GetProductReportByDate(DateTime start, DateTime end)
        {
            PolicyData policyData = new PolicyData();
            BindingSource source = new BindingSource();
            source.DataSource = policyData.sp_GetPerformanceReportByDate(start, end);
            return source;
        }
        #endregion
        //Update Methods
        #region Update
        public void UpdateProductPoliciesDetails(Product product)
        {
            ProductData productData = new ProductData();
            productData.sp_UpdateProductDetails(product);
        }

        public void UpdateProductStatus(Product product)
        {
            ProductData productData = new ProductData();
            productData.sp_UpdateProductDetails(product);
        }
        #endregion
    }
}
