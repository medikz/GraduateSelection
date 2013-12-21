<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manager.aspx.cs" Inherits="Manager" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理员界面</title>
    <style type="text/css">
        .style1
        {
            text-align: center;
            margin-left: 0px;
        }
        .style3
        {
            width: 278px;
        }
        .style4
        {
            width: 439px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <p class="style1" align="center">
                <table style="width:100%;">
                    <tr>
                    <td></td>
                        <td align="center" class="style4"> 
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" Font-Size="Large">查看学生信息</asp:LinkButton>
&nbsp; <a href="Man_Add_Stu.aspx" style="text-align:center; font-size: large;">添加学生</a><br />
        <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click" Font-Size="Large">查看教师信息</asp:LinkButton>
&nbsp; <a href="Man_Add_Tea.aspx" style="text-align:center; font-size: large;">添加老师</a><br />
        <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click" Font-Size="Large">查看课题信息</asp:LinkButton>
&nbsp; <a href="Man_Add_Sub.aspx" style="text-align:center; font-size: large;">添加课题</a></td>
                        <td></td>
                        </tr>
                        <tr>
                        <td class="style3">
                            &nbsp;</td>
                        <td class="style4" align="center">
                <asp:LinkButton ID="LinkButton4" runat="server" onclick="LinkButton4_Click" 
                                Font-Size="Large">查看选题情况</asp:LinkButton>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style3">
                            &nbsp;</td>
                        <td class="style4">
        <asp:GridView ID="GridView1" runat="server" Height="244px" 
            style="text-align: center" Width="382px" CellPadding="3" GridLines="Vertical" 
                                BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                                Font-Size="Medium">
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="#DCDCDC" />
        </asp:GridView>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style3">
                            &nbsp;</td>
                        <td class="style4" align="center">
                            <asp:LinkButton ID="LinkButton5" runat="server" onclick="LinkButton5_Click">返回 
                            登陆</asp:LinkButton>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
        </p>
        <p class="style1" align="center">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p class="style1" align="center">
                &nbsp;&nbsp; </p>
    </div>
    </form>
</body>
</html>
