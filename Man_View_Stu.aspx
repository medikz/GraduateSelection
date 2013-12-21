<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Man_View_Stu.aspx.cs" Inherits="Man_View_Stu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>学生信息概览</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" Height="244px" 
            style="text-align: center" Width="382px" CellPadding="3" GridLines="Vertical" 
                                BackColor="White" BorderColor="#999999" 
            BorderStyle="None" BorderWidth="1px" 
                                Font-Size="Medium" onrowcommand="GridView1_RowCommand">
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" 
                            CommandName="" Text="编辑"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
