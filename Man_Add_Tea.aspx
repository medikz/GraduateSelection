<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Man_Add_Tea.aspx.cs" Inherits="Man_Add_Tea" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理员-添加教师</title>
    <style type="text/css">
        .style1
        {
            text-align: center;
            font-family: 方正舒体;
            font-size: xx-large;
        }
    </style>
</head>
<body>
<style type="text/css">
        body {
            font-size: x-large;
        }
        td {
            font-size: x-large;
        }
    </style>
    <form id="form1" runat="server">
    <div class="style1" style="font-size: x-large">新增教师信息</div>
    <div>
    <table align="center">
    <tr>
    <td>工号：</td>
    <td>
        <asp:TextBox ID="txt_Tea_Id" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td>姓名：</td>
    <td>
        <asp:TextBox ID="txt_Tea_Name" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td>密码：</td>
    <td>
        <asp:TextBox ID="txt_Tea_Psd" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td>Q Q：</td>
    <td>
        <asp:TextBox ID="txt_Tea_QQ" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td>Email：</td>
    <td>
        <asp:TextBox ID="txt_Tea_Email" runat="server">@</asp:TextBox>
        </td>
    </tr>
    <tr>
    <td>电话：</td>
    <td>
        <asp:TextBox ID="txt_Tea_Tel" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td>职称：</td>
    <td>
        <asp:DropDownList ID="cmb_Tea_Prof" runat="server" Height="28px" Width="150px" 
            Font-Size="Large">
        </asp:DropDownList>
        </td>
    </tr>
    <tr>
    <td>权限：</td>
    <td>
        <asp:DropDownList ID="cmb_Tea_Role" runat="server" Height="29px" Width="150px" 
            Font-Size="Large">
        </asp:DropDownList>
        </td>
    </tr>
    <tr>
    <td>专业：</td>
    <td>
        <asp:DropDownList ID="cmb_Tea_Maj" runat="server" Height="24px" Width="147px" 
            Font-Size="Large">
        </asp:DropDownList>
        </td>
    </tr>
    </table>
    
    </div>
    <div style="text-align: center">
        <asp:Button ID="Button1" runat="server" Text="添加" onclick="Button1_Click" 
            Font-Size="Large" />
    </div>
    </form>
</body>
</html>
