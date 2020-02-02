using DA.EF;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IFsoftDemo.Admin.News
{
    public partial class NewsCategory : System.Web.UI.UserControl
    {
        DataProcess<News_Catagories> daNewCategory = new DataProcess<News_Catagories>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            DataProcess<News_Catagories> daNewCategory = new DataProcess<News_Catagories>();
            rptNewsCategory.DataSource = daNewCategory.Select();
            rptNewsCategory.DataBind();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            txtSave.Text = "Save";
            mulView.ActiveViewIndex = 1;
        }

        protected void txtSave_Click(object sender, EventArgs e)
        {
         
            if(hdInsert.Value=="update")
            {
                News_Catagories ca = new News_Catagories();
                int iD = int.Parse(hdID.Value.ToString());
                ca = daNewCategory.Select(n => n.CateID == iD).FirstOrDefault();
                if (ca != null)
                {
                    ca.Active = txtActive.Checked;
                    ca.vName = txtCatagory.Text;
                    ca.vOrder = txtOrder.Text;
                    daNewCategory.Update(ca);
                }
              
                hdID.Value = "insert";
            }
            else
            {
                News_Catagories ca = new News_Catagories();
                ca.Active = txtActive.Checked;
                ca.vName = txtCatagory.Text;
                ca.vOrder = txtOrder.Text;
                daNewCategory.Insert(ca);
         

            }
            Response.Redirect(Request.Url.ToString());

        }
        protected void msgDelete(object source, System.EventArgs e)
        {
            ((LinkButton)source).Attributes["onclick"] = "return confirm('ban muon xoa')";

         }

        protected void rptNewsCategory_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int iD = int.Parse(e.CommandArgument.ToString());
            switch (e.CommandName.ToString())
            {
               
                case "update":
                    News_Catagories ca = new News_Catagories();
                    ca= daNewCategory.Select(n => n.CateID == iD).FirstOrDefault();
                    txtCatagory.Text = ca.vName.ToString();
                    txtOrder.Text = ca.vOrder.ToString();
                    hdID.Value = e.CommandArgument.ToString();
                    hdInsert.Value = e.CommandName.ToString();
                    mulView.ActiveViewIndex = 1;
                    
                    txtSave.Text = "update";
                    break;
                case "delete":
                    News_Catagories ca1 = new News_Catagories();
                  
                    ca = daNewCategory.Select(n => n.CateID == iD).FirstOrDefault();

                    daNewCategory.Delete(ca);
                    Response.Redirect(Request.Url.ToString());

                    break;
            }
        }
    } 
}