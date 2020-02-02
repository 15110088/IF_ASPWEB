using DA.EF;
using Models.EF;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IFsoftDemo.Admin.News
{
    public partial class NewsDetail : System.Web.UI.UserControl
    {
        DataProcess<News_Detail> daNewsDetail = new DataProcess<News_Detail>();
        DataProcess<News_Catagories> daNewsCatagory = new DataProcess<News_Catagories>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCategory();
                LoadData();
                mul.ActiveViewIndex = 0;
            }
        
           
        }
        private void  LoadCategory()
        {
            drpNewcatagory.DataSource = daNewsCatagory.Select();
            drpNewcatagory.DataValueField = "CateID";
            drpNewcatagory.DataTextField = "vName";
            drpNewcatagory.DataBind();
        }
        private void LoadData()
        {
           rptTinTuc.DataSource = daNewsDetail.Select();
           rptTinTuc.DataBind();
        }
        protected void msgDelete(object source, System.EventArgs e)
        {
            ((LinkButton)source).Attributes["onclick"] = "return confirm('ban muon xoa')";

        }
        protected void btnUpload_Click(object sender, EventArgs e)
        {
           
            if(hdOption.Value=="update")
            {
                int iD = int.Parse(hdID.Value);
                string file = hdImage.Value ;
                News_Detail detail = daNewsDetail.Select(n => n.DelID == iD).FirstOrDefault();
                detail.Active = ckActive.Checked;
                detail.vTitel = txtTitle.Text;
                detail.vDesc = txtDes.Text;
                detail.vAuthor = txtAuthor.Text;
                detail.vContent = FreeTextBox1.Text;
                if(!txtUpload.FileName.Equals(""))
                {
                    file = txtUpload.FileName.Replace(txtUpload.FileName, "nghia" + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Millisecond + Path.GetExtension(txtUpload.FileName).ToLower());
                    txtUpload.PostedFile.SaveAs(Server.MapPath("/img/") + file);
                    detail.vImage = file;
                }
                
                detail.CateID = int.Parse(drpNewcatagory.SelectedValue.ToString());
                daNewsDetail.Update(detail);
                Response.Redirect(Request.Url.ToString());
            }
            else 
            {

                string sTenfile = "";
                string file = "";
                string typefile = "";
                if (txtUpload.FileName.Length > 0)
                {
                    if (txtUpload.PostedFile.ContentLength < 5000000)
                    {
                        if (txtUpload.PostedFile.ContentType.Equals("image/jpeg") || txtUpload.PostedFile.ContentType.Equals("image/x-png") || txtUpload.PostedFile.ContentType.Equals("image/png"))
                        {
                            sTenfile = txtUpload.FileName;
                            typefile = Path.GetExtension(txtUpload.FileName).ToLower();
                            file = txtUpload.FileName.Replace(sTenfile, "nghia" + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Millisecond + typefile);
                            txtUpload.PostedFile.SaveAs(Server.MapPath("/img/") + file);

                        }
                    }

                }
                News_Detail detail = new News_Detail();

                detail.Active = ckActive.Checked;
                detail.vTitel = txtTitle.Text;
                detail.vDesc = txtDes.Text;
                detail.vAuthor = txtAuthor.Text;
                detail.vContent = FreeTextBox1.Text;
                detail.vImage = file;
                detail.CateID = int.Parse(drpNewcatagory.SelectedValue.ToString());

                daNewsDetail.Insert(detail);
                Response.Redirect(Request.Url.ToString());
            }


         

        }

        protected void rptTinTuc_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int iD = int.Parse(e.CommandArgument.ToString());
            hdID.Value = e.CommandArgument.ToString();
            hdOption.Value = e.CommandName.ToString();
            News_Detail detail = daNewsDetail.Select(n => n.DelID == iD).FirstOrDefault();
            switch (e.CommandName.ToString())
            {
                case "update":
                    mul.ActiveViewIndex = 1;
                    btnUpload.Text = "Dang Cap Nhat";
                    txtAuthor.Text = detail.vAuthor;
                    txtDes.Text = detail.vDesc;
                    txtTitle.Text = detail.vTitel;
                    FreeTextBox1.Text = detail.vContent;
                    hdImage.Value = detail.vImage;
                
                    drpNewcatagory.SelectedValue = detail.CateID.ToString();
                    ckActive.Checked = Convert.ToBoolean(detail.Active);
                    break;
                case "delete":
                    daNewsDetail.Delete(detail);
                    System.IO.File.Delete(Server.MapPath("/img/") + detail.vImage);
                    Response.Redirect(Request.Url.ToString());
                    break;
                default:
                    break;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            mul.ActiveViewIndex = 1;
            btnUpload.Text = "Dang Them Moi";
        }
    }
}