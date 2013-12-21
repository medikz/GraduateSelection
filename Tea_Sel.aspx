<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tea_Sel.aspx.cs" Inherits="Tea_Sel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>教师选定</title>
</head>
<body>
<style type="text/css">
        body,td {
            font-size: x-large;
        }
        
    </style>
    
    <form id="form1" runat="server">
    <div>
    <table align="center" style="height: 122px; width: 238px">
    <tr>
    <td align="left"><b>学 号：</b></td>
    <td align="center">
        <b>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </b>
        </td>
    </tr>
    <tr>
    <td><b>姓 名：</b></td>
    <td>
        <b>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </b>
        </td>
    </tr>
    <tr>
    <td><b>课题名：</b></td>
    <td>
        <b>
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        </b>
        </td>
    </tr>
    </table>
    </div>
    <div align="center">
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="选定" 
            Height="41px" Width="67px" Font-Size="X-Large" />
    </div>
    <div style="text-align:right">
    <a href="Teacher.aspx" style="text-align: center">返回列表页面</a>
    </div>
    </form>
</body>
</html>
