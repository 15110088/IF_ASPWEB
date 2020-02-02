using DA.EF;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IFsoftDemo.Client.Product
{
    public partial class NewProduct : System.Web.UI.UserControl
    {
        DataProcess<Product_Detail> daProduct = new DataProcess<Product_Detail>();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            rptProduct.DataSource = daProduct.Select();
            rptProduct.DataBind();
        }
    }
    
}