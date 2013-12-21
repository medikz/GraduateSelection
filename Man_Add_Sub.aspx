<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Man_Add_Sub.aspx.cs" Inherits="Man_Add_Sub" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理员-添加课程</title>
    <style type="text/css">
        .style1
        {
            font-size: xx-large;
            font-family: 方正舒体;
        }
    </style>
</head>
<body style="text-align: center" align="center" >
<style type="text/css">
        body {
            font-size: x-large;
        }
    </style>
    
    <form id="form1" runat="server">
    <div align="center" class="style1">添加课题</div>
    <div>
    <table style="text-align: center" align="center">
    <tr>
    <td style="text-align: left">课题号：</td>
    <td align="left">
        <asp:TextBox ID="txt_Sub_Id" runat="server" style="text-align: left" 
            Height="24px" Width="167px"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td>课题名称：</td>
    <td align="left">
        <asp:TextBox ID="txt_Sub_Name" runat="server" style="text-align: left" 
            Height="24px" Width="168px"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td>指导教师：</td>
    <td align="left">
        <asp:DropDownList ID="comboBox1" runat="server" Width="99px" 
            AutoPostBack="True" onselectedindexchanged="comboBox1_SelectedIndexChanged" 
            ontextchanged="comboBox1_TextChanged" Font-Size="X-Large">
        </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>
        </td>
    </tr>
    <tr>
    <td>课题简介：</td>
    <td>
        <asp:TextBox ID="rxt_Sub_Info" runat="server" Height="205px" 
            TextMode="MultiLine" Width="268px"></asp:TextBox>
        </td>
    </tr>
    </table>
    </div>
    <div style="font-size: large">
        <asp:Button ID="Button1" runat="server" Text="添加" onclick="Button1_Click" 
            Font-Size="X-Large" Height="41px" Width="91px" />
    </div>
    </form>
</body>
</html>
