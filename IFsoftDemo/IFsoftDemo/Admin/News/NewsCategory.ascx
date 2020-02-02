<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewsCategory.ascx.cs" Inherits="IFsoftDemo.Admin.News.NewsCategory"  %>

<asp:MultiView ID="mulView" ActiveViewIndex="0" runat="server">
     
    <asp:View ID="v1" runat="server">
         <form ID="frm1" runat="server">
        <div>
     <asp:Repeater ID="rptNewsCategory" runat="server" OnItemCommand="rptNewsCategory_ItemCommand">
         <HeaderTemplate>
             <table style="width:100%;">
                 <tr>
                     <td style="width:50px;">ID</td>
                     
                     <td style="width:50px;">Name</td>
                     <td style="width:50px;">Order</td>
                     <td style="width:50px;">Active</td>
                       <td style="width:50px;"></td>
                 </tr>
         </HeaderTemplate>
         <ItemTemplate>
             <tr>
                 <td>
                  
                         <asp:LinkButton ID="txtUpdate" runat="server" CommandName="update" CommandArgument='<%#:Eval("CateID")%>'><%#:Eval("CateID")%> </asp:LinkButton>
                     
                      

                 </td>
                  <td><%#:Eval("vName")%></td>
                  <td><%#:Eval("vOrder")%></td>
                  <td><%#:Eval("Active")%></td>
                 <td>   <asp:LinkButton ID="aaa"  CommandName="delete" CommandArgument='<%#:Eval("CateID")%>' runat="server" OnLoad="msgDelete"> Xoa </asp:LinkButton></td>
             </tr>
         </ItemTemplate>
         <FooterTemplate>
             </table>
         </FooterTemplate>
     </asp:Repeater>
        
    </div>
      
  <asp:LinkButton ID="btnAddNew" runat="server" OnClick="btnAddNew_Click" >Add New</asp:LinkButton>
 </form>
           
        
       
        
    </asp:View>
    <asp:View ID="v2" runat="server">
        
        <form ID="frm2" runat="server">
            <asp:HiddenField ID="hdID" runat="server" />
             <asp:HiddenField ID="hdInsert" runat="server" />
            <table >
            <tr>
                <td>Category Name</td>
                <td><asp:TextBox ID="txtCatagory" runat="server"></asp:TextBox> </td>
               
            </tr>
            <tr>
                <td>Order</td>
                <td><asp:TextBox ID="txtOrder" runat="server"></asp:TextBox> </td>
               
            </tr>
             <tr>
                <td>Active</td>
                <td><asp:CheckBox ID="txtActive" runat="server" Checked="true"></asp:CheckBox> </td>
               
            </tr>
                 <tr>
                <td></td>
                <td><asp:Button ID="txtSave" runat="server" Text="Save" OnClick="txtSave_Click" ></asp:Button> </td>
               
            </tr>
        </table>
             </form>
    </asp:View>
</asp:MultiView>
