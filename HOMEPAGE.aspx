  <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HOMEPAGE.aspx.cs" Inherits="MAIM_PROJECT_BLOOD_MANAGEMENT.HOMEPAGE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 677px;
        }
        .auto-style2 {
            height: 220px;
        }
        .auto-style3 {
            margin-left: 52px;
        }
        .auto-style4 {
            height: 52px;
            text-align: center;
            color: #FFFFFF;
            font-size: large;
            background-color: #FF0000;
        }
        .auto-style5 {
            height: 346px;
            width: 143px;
        }
        .auto-style24 {
            height: 729px;
            width: 1528px;
        }
        .auto-style28 {
            width: 1415px;
        }
        .auto-style29 {
            margin-left: 6px;
        }
        .auto-style30 {
            width: 935px;
            height: 251px;
        }
               
        .auto-style31 {
            font-size: large;
            font-family: "Calibri Light";
        }
       
        </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style24">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="3">
                    <asp:Image ID="Image1" runat="server" CssClass="auto-style3" Height="210px" ImageUrl="~/image/Picsart_23-09-04_10-50-46-627 HEADING.jpg" Width="1476px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="3"><strong>Donate blood and be the reason for someone&#39;s existence.</strong></td>
            </tr>
            <tr>
                <td class="auto-style5" rowspan="3">
                    <asp:Menu ID="Menu2" runat="server" Font-Bold="True">
                        <DynamicHoverStyle BackColor="Red" BorderColor="White" BorderStyle="Groove" Font-Bold="True" />
                        <DynamicMenuItemStyle BackColor="Red" BorderStyle="Groove" ForeColor="White" />
                        <DynamicMenuStyle BackColor="#FB4F6C" BorderColor="White" BorderStyle="None" HorizontalPadding="10px" />
                        <DynamicSelectedStyle BackColor="Red" BorderColor="White" BorderStyle="Groove" ForeColor="White" />
                        <Items>
                            <asp:MenuItem NavigateUrl="~/register.aspx" Text="REGISTER" Value="REGISTER"></asp:MenuItem>
                            <asp:MenuItem Text="LOGIN" Value="HOME">
                                <asp:MenuItem NavigateUrl="~/ADMINLOGIN.aspx" Text="ADMIN" Value="ADMIN"></asp:MenuItem>
                                <asp:MenuItem NavigateUrl="~/USERLOGIN.aspx" Text="USER " Value="New Item"></asp:MenuItem>
                            </asp:MenuItem>
                            <asp:MenuItem NavigateUrl="~/SEARCH.aspx" Text="SEARCH" Value="SEARCH"></asp:MenuItem>
                        </Items>
                        <StaticHoverStyle BackColor="#FB7197" BorderColor="White" BorderStyle="None" Font-Bold="True" ForeColor="White" />
                        <StaticMenuItemStyle BackColor="Red" ForeColor="White" HorizontalPadding="25px" VerticalPadding="55px" />
                        <StaticMenuStyle BackColor="Red" BorderColor="White" />
                        <StaticSelectedStyle BackColor="#FD577C" BorderStyle="None" />
                    </asp:Menu>
                </td>
            </tr>
            <tr>
                <td class="auto-style30">
                    <asp:Image ID="Image2" runat="server" CssClass="auto-style29" Height="277px" ImageUrl="~/image/0_khKmX-V7NlqF97gK.jpg" Width="930px" />
                      <strong>
                    <br />
&nbsp;<span class="auto-style31">»» Donate blood and save lives.</span><br class="auto-style31" />
                    <span class="auto-style31">&nbsp;»» Instead of giving your blood to mosquitoes, give it to someone who needs it. </span>
                    <br class="auto-style31" />
                    <span class="auto-style31">&nbsp;»» One bag of blood can bring back one from the dead.<br />
&nbsp;»» The bond of blood is stronger than anything. </span></strong>
                     <td class="auto-style28" rowspan="2" direction="left" >
                   
                         <asp:Image ID="Image3" runat="server" Height="398px" ImageUrl="~/image/BLOOD DONATION IMAGE 1.jpg" Width="425px" />
                </td>  
                    </tr>
              
        </table>
    </form>
</body>
</html>
