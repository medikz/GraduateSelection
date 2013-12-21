<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Teacher.aspx.cs" Inherits="Teacher" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>教师界面</title>
    <style type="text/css">
        body,td {
            font-size: x-large;
        }
        .auto-style1
        {
            width: 872px;
        }
        .style3
        {
            width: 238px;
        }
        .style4
        {
            width: 206px;
        }
        .style5
        {
            width: 227px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="style7" colspan="4" align="left">
                    <span class="style8" style="background-color: #000080; color: #FFFFFF">[教师信息]</span></td>
            </tr>
            <tr>
                <td class="style3">
                    工 号:<asp:TextBox ID="txtTeaNo" runat="server" Width="89px" BackColor="#CCCCCC" 
                        Font-Size="Large" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;
                    <br />
                </td>
                <td class="style5">
                    密码:<asp:TextBox ID="txtPwd" runat="server" style="text-align: left" 
                        Width="144px" Font-Size="Large"></asp:TextBox>
                </td>
                <td class="style4">
                    专业:<asp:TextBox ID="txtMajor" runat="server" Width="118px" Font-Size="Large"></asp:TextBox>
                </td>
                <td class="style14">
                    职称:<asp:TextBox ID="txtPro" runat="server" Width="109px" Font-Size="Large"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Email:<asp:TextBox ID="txtEmail" runat="server" Width="158px" 
                        Font-Size="Large"></asp:TextBox>
                </td>
                <td class="style5">
                    电话:<asp:TextBox ID="txtTel" runat="server" style="text-align: left" 
                        Width="148px" Font-Size="Large"></asp:TextBox>
                </td>
                <td class="style4">
                    &nbsp;</td>
                <td class="auto-style&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9" bgcolor="White">
                    <span class="style8">
                    <asp:Button ID="btnEditTea" runat="server" Height="32px" 
                        onclick="btnEditTea_Click" Text="修改信息" Width="145px" Font-Size="Large" 
                        style="text-align: left" />
                    </span>
                </td>
            </tr>
            <tr> 
                <td>
                    <span class="style6" style="color: #FFFFFF; background-color: #800080">[课题信息]</span>
                <td></td><td></td><td></td>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style12" colspan="4">
                    <asp:GridView ID="GridView_Sub" runat="server">
                    </asp:GridView>
                    <br />
                    编 号:<asp:TextBox ID="txtSubNo" runat="server" BackColor="White" 
                        Font-Size="Large" Width="160px"></asp:TextBox>
                    名称:<asp:TextBox ID="txtSubName" runat="server" Font-Size="Large" 
                        Width="351px"></asp:TextBox>
                    <span class="style8">&nbsp;
                    </span>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="添加课题" />
                </td>
            </tr>
            <tr>
                <td class="auto-style9" colspan="4">
                    <asp:TextBox ID="txtSubInfo" runat="server" Height="101px" TextMode="MultiLine" 
                        Width="848px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
        <table style="width: 77%; height: 290px;">
            <tr>
                <td class="style9">
                    第一志愿学生：</td>
                <td class="style10">
                    第二志愿学生：</td>
            </tr>
            <tr>
                <td class="style9">
    
        <asp:GridView ID="dataGridView1" runat="server" 
            onrowcommand="dataGridView1_RowCommand" CellPadding="4" 
            ForeColor="#333333" GridLines="None">
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" 
                            CommandName="" Text="选定"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    
                </td>
                <td class="style10">
    
        <asp:GridView ID="dataGridView2" runat="server" 
            onrowcommand="dataGridView1_RowCommand" CellPadding="4" 
            ForeColor="#333333" GridLines="None">
            <RowStyle BackColor="#E3EAEB" />
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="false" 
                            CommandName="" Text="选定"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    
                </td>
            </tr>
            <tr>
                <td class="style9">
                    <span class="style6">[学生信息] </span>&nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" 
                        runat="server" AutoPostBack="True" 
            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Font-Size="X-Large" 
                        Width="143px" >
        </asp:DropDownList>
                </td>
                <td class="style10">
        学生选择:<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Font-Size="X-Large" 
                        Width="143px" >
        </asp:DropDownList>
                </td>
            </tr>
        </table>
        <br />
    
    </div>
    </form>
</body>
</html>
