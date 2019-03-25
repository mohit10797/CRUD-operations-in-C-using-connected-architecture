<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Address_Book_Connected_Architecture_.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 209px;
        }
        .auto-style3 {
            width: 130px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Address Id</td>
                    <td class="auto-style3">
            <input ID="Textid" runat="server"></input>
            
                    </td>
                    <td>
                        <asp:Button ID="search_button" runat="server" Text="Search" OnClick="Search_button_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">First Name</td>
                    <td class="auto-style3">
            <asp:TextBox ID="Textfname" runat="server"></asp:TextBox>
            
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;Last Name</td>
                    <td class="auto-style3">
            <asp:TextBox ID="Textlname" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Email</td>
                    <td class="auto-style3">
            <asp:TextBox ID="Textemail" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Phone</td>
                    <td class="auto-style3">
            <asp:TextBox ID="Textphone" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Insert_button" runat="server" Text="Insert" OnClick="Insert_button_Click" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="Update_button" runat="server" Text="Update" OnClick="Update_button_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Delete_button" runat="server" Text="Delete" OnClick="Delete_button_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        Search Record Using Last Name</td>
                    <td class="auto-style3">
            <asp:TextBox ID="Textid0" runat="server"></asp:TextBox>
            
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Find_lastname" runat="server" Text="Find" OnClick="Find_lastname_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Browse_all_enteries" runat="server" Text="Browse All Enteries" OnClick="Browse_all_enteries_Click" />
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
