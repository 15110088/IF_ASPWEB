<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminControl.ascx.cs" Inherits="IFsoftDemo.Admin.AdminControl" %>
<%@ Register Src="Menu.ascx" tagname="Menu" tagprefix="uc1" %> <%-- dang ky user control--%>
<h1>Admin hien ra</h1>

<table cellspacing="0" cellpadding="0" style="width:100%" >
    <tr>
        <td style="width:200px;"><uc1:Menu ID="Menu1" runat="server"/></td>
         <td style="width:10px;">&nbsp</td>
        <td>
            
                
            <asp:PlaceHolder ID="plLoad" runat="server"></asp:PlaceHolder>
              
        </td>
        <td>
           </td>
    </tr>

</table>


