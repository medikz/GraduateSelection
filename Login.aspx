<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>医疗器械与食品学院-2014届毕业设计选题系统</title>
   <!-- 增加JQuery 的支持1123 -->
<script language = "javascript" type="text/javascript" src = "JScript/jquery-1.10.2.js"></script>
    <script type="text/javascript">
          /*  $(function () {
            //var userBox = $("#<%=textBox1.ClientID %>");
           // $("#<%=textBox1.ClientID%>").focus();
           
            var searchBox = $("#<%=textBox1.ClientID %>"); 
            searchBox.focus(function () 
            { 
                    if (searchBox.val() == this.title) { // TextBox控件ToolTip属性转换为Html为title属性 
                    searchBox.val(""); 
            } 
            }); 
            searchBox.blur(function () { 
            if (searchBox.val() == "") { 
            searchBox.val(this.title); 
            } 
            }); 
            searchBox.blur(); 
           });

*/
    </script>
    
    <style type="text/css">
        .style1
        {
            font-size: xx-large;
            font-family: 华文宋体;
        }
        .style2
        {
        }
        .style5
        {
            height: 50px;
            font-weight: bold;
        }
        body
        {
		background-repeat: no-repeat;
	}
        .style6
        {
            font-weight: bold;
        }
        #form1
        {
            text-align: center;
        }
        </style>
    </head>
    <form id="form1" runat="server">
    
<body  >
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <p class="style1" 
    style="text-align: center; font-size: xx-large; font-family: 华文细黑;" 
    align="center">医疗器械与食品学院</p>
<p class="style1" 
    style="text-align: center; font-family: 微软雅黑; font-size: x-large;" 
    align="center">2014届毕业设计选题系统</p>
            <table align="center" style="width: 60%; height: 167px;">
                <tr>
                    <td class="style5" align="center" colspan="3">
                        <asp:Label ID="LabelID" runat="server" Text="学 号"></asp:Label>
                        :<b><asp:TextBox ID="textBox1" runat="server" Font-Size="Large" 
                            Width="206px" 
                            ToolTip="密码:出生年月日YYYYMMDD"></asp:TextBox>
                        </b>
                        
                    </td>
                </tr>
                <tr>
                    <td class="style6" align="center" colspan="3">
                        <asp:Label ID="LabelPWD" runat="server" Text="密 码"></asp:Label>
                        :<b><asp:TextBox ID="textBox2" runat="server" TextMode="Password" 
                            Font-Size="Large" Width="206px" ToolTip="密码:出生年月日YYYYMMDD">101</asp:TextBox>
                        </b>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="style2" colspan="3">
                        <b>
            <asp:RadioButton ID="radio_Stu" runat="server" Text="学生" Checked="True" 
                GroupName="1" Font-Size="Large" AutoPostBack="True" 
                            oncheckedchanged="radio_Stu_CheckedChanged" />
                    &nbsp;
            <asp:RadioButton ID="radio_Tea" runat="server" Text="教师" GroupName="1" 
                oncheckedchanged="radio_Tea_CheckedChanged" Font-Size="Large" AutoPostBack="True" />
                    &nbsp;
            <asp:RadioButton ID="radio_Man" runat="server" Text="管理员" GroupName="1" Font-Size="Large" 
                            AutoPostBack="True" oncheckedchanged="radio_Man_CheckedChanged" />
                        </b>
                    </td>
                </tr>
                <tr><td></td><td align="center">
        <asp:Button ID="Button1" runat="server" Text="登录" onclick="Button1_Click" 
                Font-Size="Large" style="font-weight: 700" BorderStyle="Solid" Height="41px" />
                    </td><td></td></tr>
            </table>
<br />
<br />
<br />
<br />
上海理工大学 医疗器械与食品学院 ,技术支持:Email:<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Mailto:zju_kxy@126.com">zju_kxy@126.om</asp:HyperLink>
，孔老师
    </form>
    </body>
</html>
