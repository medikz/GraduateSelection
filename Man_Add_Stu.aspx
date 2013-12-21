<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Man_Add_Stu.aspx.cs" Inherits="Man_Add_Stu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理员-添加学生</title>
    <style type="text/css">
        .style1
        {
            font-size: x-large;
            font-family: 华文彩云;
        }
    </style>
</head>
<body>
   <style type="text/css">
        body {
            font-size: x-large;
        }
    </style>
    <form id="form1" runat="server">
    <div>
    <table style="text-align:center" align="center">
    <tr>
    <td class="style1">学生信息</td>
    </tr>
    <tr>
    <td>学号：</td>
    <td>
        <asp:TextBox ID="txt_Stu_Id" runat="server" Font-Size="Large"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td>姓名：</td>
    <td>
        <asp:TextBox ID="txt_Stu_Name" runat="server" Font-Size="Large"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td>密码：</td>
    <td align="left">
        <asp:TextBox ID="txt_Stu_Psd" runat="server" TextMode="Password" 
            Font-Size="Large"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td>性别：</td>
    <td align="left">
        <asp:DropDownList ID="comboBox1" runat="server" Height="25px" Width="107px" 
            Font-Size="Large">
        </asp:DropDownList>
        </td>
    </tr>
    </table>
    <table style="text-align:center" align="center">
    <tr>
    <td>QQ号：</td>
    <td>
        <asp:TextBox ID="txt_Stu_QQ" runat="server" Font-Size="Large"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td>E-Mail：</td>
    <td>
        <asp:TextBox ID="txt_Stu_Email" runat="server" Font-Size="Large">@</asp:TextBox>
        </td>
    </tr>
    <tr>
    <td>电话：</td>
    <td>
        <asp:TextBox ID="txt_Stu_Tel" runat="server" Font-Size="Large"></asp:TextBox>
        </td>
    </tr>
        <tr>
    <td>专业：</td>
    <td align="left">
        <asp:DropDownList ID="comboBox2" runat="server" Font-Size="Large" Width="207px">
        </asp:DropDownList>
        </td>
    </tr>
    </table>
    </div>
    <div style="text-align: center">
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="添加" 
            Font-Size="X-Large" Font-Bold="True" />
    </div>
    </form>
</body>
</html>
