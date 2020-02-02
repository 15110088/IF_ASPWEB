<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewsDetail.ascx.cs" Inherits="IFsoftDemo.Admin.News.NewsDetail" %>
<%@ Register Assembly="FreeTextBox" Namespace="FreeTextBoxControls" TagPrefix="FTB" %>

<asp:MultiView ID="mul" ActiveViewIndex="0" runat="server">
     <asp:View ID="v0" runat="server">
     <form id="frm1" runat="server">
         <div>
           <asp:Repeater ID="rptTinTuc" runat="server" OnItemCommand="rptTinTuc_ItemCommand">
               <HeaderTemplate>
                   <table>
                       <tr>
                           <td style="width:100px">Image</td>
                            <td style="width:400px">Title</td>
                            <td style="width:100px">Author</td>
                            <td style="width:100px">Active</td>
                            <td ></td>
                       </tr>
               </HeaderTemplate>
               <ItemTemplate>
                    <tr>
                           <td > <img  style="width:100px" src='../../img/<%#:Eval("vImage")%>'></img></td>
                            <td style="width:400px"><%#:Eval("vTitel")%></td>
                            <td style="width:100px"><%#:Eval("vAuthor")%></td>
                            <td style="width:100px"><%#:Eval("Active")%></td>
                            <td><asp:LinkButton ID="btnUpdate" runat="server" CommandName="update" CommandArgument='<%#:Eval("DelID") %>'>Cap Nhat</asp:LinkButton>  &nbsp|&nbsp
                             <asp:LinkButton ID="btnDelete" runat="server" CommandName="delete" OnLoad="msgDelete" CommandArgument='<%#:Eval("DelID") %>'>Xoa</asp:LinkButton> 

                            </td>
                       </tr>
               </ItemTemplate>
               <FooterTemplate>
                   </table>
               </FooterTemplate>
           </asp:Repeater>
             <asp:LinkButton ID="btnAdd" runat="server" OnClick="btnAdd_Click" >Them moi</asp:LinkButton>
         </div>
      </form>
    </asp:View>
    <asp:View ID="v1" runat="server">
       
        <form id="frm" runat="server">
             <asp:HiddenField id="hdOption" runat="server"/>
        <asp:HiddenField id="hdID" runat="server"/>
            <asp:HiddenField id="hdImage" runat="server"/>
            <table style="width:100%">
                <tr>
                    <td >New catagory</td>
                    <td style="width:10px"></td>
                    <td><asp:DropDownList ID="drpNewcatagory" runat="server"></asp:DropDownList></td>
                </tr>
                 <tr>
                    <td >title</td>
                    <td style="width:10px"></td>
                    <td><asp:TextBox ID="txtTitle" Width="500px" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td >des</td>
                    <td style="width:10px"></td>
                    <td><asp:TextBox ID="txtDes" TextMode="MultiLine"  Width="500px" runat="server"></asp:TextBox></td>
                </tr>
                    <tr>
                    <td >Content</td>
                    <td style="width:10px"></td>
                    <td><FTB:FreeTextBox ID="FreeTextBox1" runat="server"></FTB:FreeTextBox></td>
                </tr>
                   <tr>
                    <td >Image</td>
                    <td style="width:10px"></td>
                    <td><asp:FileUpload ID="txtUpload" Width="500px" runat="server"></asp:FileUpload></td>
                </tr>
                <tr>
                    <td >Author</td>
                    <td style="width:10px"></td>
                    <td><asp:TextBox ID="txtAuthor" Width="500px" runat="server"></asp:TextBox></td>
                </tr>
                   <tr>
                    <td >Active</td>
                    <td style="width:10px"></td>
                    <td><asp:CheckBox ID="ckActive" runat="server"></asp:CheckBox></td>
                </tr>
            </table>
            
            <asp:Button ID="btnUpload" runat="server" Text="UpLoad" OnClick="btnUpload_Click" />
        </form>
    </asp:View>
  


</asp:MultiView>


