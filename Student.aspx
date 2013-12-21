<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Student.aspx.cs" Inherits="Student" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>选课界面</title>
    <style type="text/css">
        .style2
        {
            width: 404px;
            height: 33px;
            font-weight: bold;
            color: #000000;
        }
        .style4
        {
        }
        .style5
        {
            width: 164px;
            font-weight: bold;
            color: #003300;
        }
        .style9
        {
            width: 153px;
            height: 192px;
        }
        .style10
        {
            width: 404px;
            height: 192px;
        }
        .style13
        {
            width: 153px;
            font-weight: bold;
            height: 33px;
            color: #FFFFFF;
        }
        .style14
        {
            height: 192px;
        }
        .style15
        {
            height: 33px;
            font-weight: bold;
            color: #000000;
        }
        .style18
        {
            font-size: larger;
            color: #003300;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left" align="center">
        <table style="height: 202px; width: 951px;" bgcolor="#003366">
            <tr bgcolor="#CCCCCC">
                
                <td class="style2" bgcolor="White">
                    已选第一志愿：</td>
                    <td class="style15" bgcolor="White">已选第二志愿：</td>
                    <td class="style13">
                    选题说明：</td>
            </tr>
            <tr bgcolor="#FFFF99">
                
                <td class="style10" align="center">
        <asp:GridView ID="GridView1" runat="server" style="text-align: left; margin-top: 0px;" 
                        CellPadding="4" Width="370px" ForeColor="#333333" GridLines="None" 
                        Font-Bold="True" Font-Size="Medium">
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
                </td>
                <td class="style14" align="center" bgcolor="White">
                    <asp:GridView ID="GridView2" runat="server" style="text-align: left; margin-top: 0px;" 
                        CellPadding="4" Width="365px" ForeColor="#333333" GridLines="None" 
                        Font-Bold="True" Font-Size="Medium">
                        <RowStyle BackColor="#E3EAEB" />
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#7C6F57" />
                        <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
                </td><td class="style9" bgcolor="White">
                    <br />
                    <b>1. 一人一题；<br />
                    2. 每人最多选两个志愿。<br />
                    3.选课有问题请联系管理员：kxy@medikz.com</b><br />
                    </td>
            </tr>
            </table>
        <br />
        <table style="height: 194px; width: 932px">
            <tr>
                <td class="style5" bgcolor="White">
                    可选课题：</td>
                <td bgcolor="White" class="style18">
                    <b>指导教师：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
                        Font-Size="Large">
                        <asp:ListItem Value="0">全部</asp:ListItem>
                    </asp:DropDownList>
                    </b>
                </td>
            </tr>
            <tr>
                <td class="style4" colspan="2">
                    <asp:GridView ID="dataGridView1" runat="server" style="text-align: left" 
            onrowcommand="dataGridView1_RowCommand" 
            onrowdatabound="dataGridView1_RowDataBound" 
            onselectedindexchanged="dataGridView1_SelectedIndexChanged" BackColor="#CCCCCC" 
                        BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
                        CellPadding="4" CellSpacing="2" ForeColor="Black" Height="171px" 
                        Width="794px">
                        <RowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" 
                            CommandName="" onclick="LinkButton1_Click" Text="查看-选择"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
                    <br />
                </td>
            </tr>
            </table>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Login.aspx">返回主页</asp:HyperLink>
        <br />
    </div>
    </form>
</body>
</html>
