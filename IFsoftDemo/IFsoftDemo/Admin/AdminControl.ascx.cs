using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IFsoftDemo.Admin
{
    public partial class AdminControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request["f"];
            Console.Write("nghia");
            switch(s)
            {
                case "news":
                    plLoad.Controls.Add(LoadControl("News/NewsControl.ascx"));
                    Console.Write("nghia1");
                    break;
                case "product":
                    plLoad.Controls.Add(LoadControl("Product/ProductControl.ascx"));
                    Console.Write("nghia2");
                    break;
                default:
                    break;

            }
        }
    }
}