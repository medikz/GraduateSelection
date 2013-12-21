<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Stu_Sel.aspx.cs" Inherits="Stu_Sel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>选定课题</title>
    <style type="text/css">
        .style1
        {
            width: 121px;
            font-weight: bold;
        }
        .style2
        {
            width: 121px;
            height: 34px;
            font-weight: bold;
        }
        .style3
        {
            height: 34px;
        }
        .style4
        {
            width: 121px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="left" style="height: 437px; width: 951px">
    <table align="left" style="height: 428px; width: 698px">
    <tr>
    <td class="style1">课程名称：</td>
    <td>
        <b>
        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" Width="322px" 
            Font-Size="Medium" Height="36px"></asp:TextBox>
        </b>
        </td>
    </tr>
    <tr>
    <td class="style1">课程简介：</td>
    <td>
        <b>
        <asp:TextBox ID="richTextBox1" runat="server" TextMode="MultiLine" 
            Height="272px" Width="320px" Font-Size="Medium"></asp:TextBox>
        </b>
        </td>
    </tr>
     <tr>
    <td class="style2">选题志愿：</td>
    <td class="style3" align="left">
        <b>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            Width="127px" Font-Bold="True" Font-Size="Large">
            <asp:ListItem Value="1">第一志愿</asp:ListItem>
            <asp:ListItem Value="2">第二志愿</asp:ListItem>
        </asp:DropDownList>
    &nbsp;
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="选择" 
            Font-Bold="False" Font-Size="Medium" Height="29px" Width="54px" />
        </b>
    </td>
</tr>
<tr>
    <td class="style4">
        <br />
    </td>
     <td>
         <br />
        <a href="Student.aspx" style="text-align: center; font-size: large;">返回选题</a><br />
    </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
