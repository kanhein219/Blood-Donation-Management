<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SEARCH.aspx.cs" Inherits="MAIM_PROJECT_BLOOD_MANAGEMENT.SEARCH1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style19 {
            font-size: large;
            color: #FFFFFF;
        }
        .auto-style1 {
            width: 100%;
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
            background-color: #FF0000;
        }
        .auto-style5 {
            height: 365px;
            width: 143px;
        }
        .auto-style20 {
            font-size: large;
        }
        .auto-style21 {
            text-align: center;
        }
        .auto-style22 {
            width: 143px;
        }
        .auto-style23 {
            text-align: left;
        }
        .auto-style24 {
            width: 1432px;
        }
        .auto-style25 {
            font-size: large;
            font-weight: bold;
            color: #FFFFFF;
            background-color: #FF0000;
        }
        .auto-style26 {
            font-size: large;
            font-weight: bold;
            color: #993333;
        }
        .auto-style27 {
            color: #990000;
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Image ID="Image1" runat="server" CssClass="auto-style3" Height="210px" ImageUrl="~/image/Picsart_23-09-04_10-50-46-627 HEADING.jpg" Width="1476px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="2"><strong><span class="auto-style19">Stay fit and eat right and donate blood.</span></strong>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5" rowspan="2">
                    <asp:Menu ID="Menu2" runat="server" OnMenuItemClick="Menu2_MenuItemClick">
                        <DynamicHoverStyle BackColor="#FF6A6A" />
                        <DynamicMenuItemStyle BackColor="Red" BorderColor="White" BorderStyle="Groove" Font-Bold="True" ForeColor="White" HorizontalPadding="10px" VerticalPadding="10px" />
                        <Items>
                            <asp:MenuItem Text="HOME" Value="HOME"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="~/register.aspx" Text="REGISTER" Value="REGISTER"></asp:MenuItem>
                            <asp:MenuItem Text="LOGIN" Value="SEARCH">
                                <asp:MenuItem NavigateUrl="~/ADMINLOGIN.aspx" Text="ADMIN" Value="ADMIN"></asp:MenuItem>
                                <asp:MenuItem NavigateUrl="~/USERLOGIN.aspx" Text="USER" Value="USER"></asp:MenuItem>
                            </asp:MenuItem>
                            <asp:MenuItem Text="LOGOUT" Value="REGISTER"></asp:MenuItem>
                        </Items>
                        <StaticHoverStyle BackColor="Red" />
                        <StaticMenuItemStyle BackColor="Red" BorderColor="Black" ForeColor="White" HorizontalPadding="25px" VerticalPadding="65px" />
                        <StaticMenuStyle BackColor="#FE5F7A" />
                        <StaticSelectedStyle BackColor="Red" VerticalPadding="20px" />
                    </asp:Menu>
&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style24">
                    <h1 class="auto-style23">&nbsp;<span class="auto-style27">SEARCH AVAILABLE DONOR</span></h1>
                    <p class="auto-style23">
                        <span class="auto-style26">BLOOD GROUP&nbsp;&nbsp; </span>
                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style26">
                            <asp:ListItem>--Blood Group--</asp:ListItem>
                            <asp:ListItem>A+</asp:ListItem>
                            <asp:ListItem>A-</asp:ListItem>
                            <asp:ListItem>B+</asp:ListItem>
                            <asp:ListItem>B-</asp:ListItem>
                            <asp:ListItem>AB+</asp:ListItem>
                            <asp:ListItem>AB-</asp:ListItem>
                            <asp:ListItem>O+</asp:ListItem>
                            <asp:ListItem>O-</asp:ListItem>
                        </asp:DropDownList>
                    </p>
                    <p class="auto-style23">
                        <span class="auto-style26">STATE&nbsp;&nbsp;&nbsp; </span>
                        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="auto-style26" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                        </asp:DropDownList>
                    </p>
                    <p class="auto-style23">
                        <span class="auto-style26">CITY&nbsp;&nbsp; </span>
                        <asp:DropDownList ID="DropDownList3" runat="server" CssClass="auto-style26" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                        </asp:DropDownList>
                    </p>
                    <p class="auto-style23">
                        <strong>&nbsp;<asp:Button ID="Button1" runat="server" CssClass="auto-style25" Text="SEARCH" OnClick="Button1_Click" />
                        </strong>
                    </p>
                    <p class="auto-style23">
                        <strong>
                        <asp:Label ID="Label1" runat="server" CssClass="auto-style20" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                        </strong>
                    </p>
                        <div class="auto-style21">
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="966px" Height="201px">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="UID" HeaderText="DONAR ID" />
                                    <asp:BoundField DataField="UNAME" HeaderText="DONAR NAME" />
                                    <asp:BoundField DataField="BGROUP" HeaderText="BLOOD GROUP" />
                                    <asp:BoundField DataField="PHNO" HeaderText="PHNO" />
                                    <asp:BoundField DataField="email" HeaderText="EMAIL" />
                                    <asp:BoundField DataField="CITY" HeaderText="CITY" />
                                    <asp:BoundField DataField="regdate" HeaderText="Available From" />
                                </Columns>
                                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                                <SortedDescendingHeaderStyle BackColor="#820000" />
                            </asp:GridView>
                        </div>
                    <br />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            </tr>
            <tr>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
