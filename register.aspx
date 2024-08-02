<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="MAIM_PROJECT_BLOOD_MANAGEMENT.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 220px;
        }
        .auto-style3 {
            margin-left: 52px;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            height: 52px;
            text-align: center;
            color: #FFFFFF;
            font-size: large;
            background-color: #FF0000;
        }
        .auto-style5 {
            color: #990033;
            text-align: center;
            font-size: large;
        }
        .auto-style6 {
            color: #800000;
            text-align: center;
        }
        .auto-style8 {
            font-size: large;
        }
        .auto-style9 {
            font-size: large;
            color: #990033;
            margin-left: 0px;
        }
        .auto-style10 {
            font-size: large;
            font-weight: bold;
            color: #990033;
            background-color: #FF0000;
        }
        .auto-style12 {
            font-size: large;
            color: #990033;
        }
        .auto-style15 {
            color: #800000;
            text-align: center;
            font-size: large;
        }
        .auto-style16 {
            color: #990033;
        }
        .auto-style13 {
            color: #FF0000;
            font-size: x-large;
        }
        .auto-style18 {
            text-align: center;
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Image ID="Image1" runat="server" CssClass="auto-style3" Height="210px" ImageUrl="~/image/Picsart_23-09-04_10-50-46-627 HEADING.jpg" Width="1476px" />
                </td>
            </tr>
        </table>
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4"><strong>Saving a life won’t cost you anything. Go ahead and donate blood.</strong></td>
                </tr>
            </table>
        </div>
        <div class="auto-style18">
            <strong>
            <br />
            -----------------------------------<asp:Label ID="Label2" runat="server" Text="REGISTER"></asp:Label>
&nbsp;AS A DONOR-----------------------------------</strong></div>
        <p class="auto-style5">
            <asp:Label ID="Label1" runat="server" CssClass="auto-style13" ForeColor="#003300" Text="Label" Visible="False"></asp:Label>
            &nbsp;&nbsp;</p>
        <p class="auto-style6">
            <strong><span class="auto-style16"><span class="auto-style8"> USER NAME&nbsp;&nbsp;&nbsp;&nbsp; </span></span>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style12"></asp:TextBox>
            </strong></p>
        <p class="auto-style6">
            <strong><span class="auto-style12">GENDER&nbsp;&nbsp;&nbsp;&nbsp; </span></strong><span class="auto-style16"><strong>
            <asp:RadioButton ID="RadioButton1" runat="server" CssClass="auto-style8" GroupName="G" Text="MALE" />
            </strong>&nbsp;<strong><asp:RadioButton ID="RadioButton2" runat="server" CssClass="auto-style8" GroupName="G" Text="FEMALE" />
            </strong></span>
        </p>
        <p class="auto-style6">
            <strong><span class="auto-style12">LANGUAGES</span></strong><span class="auto-style16"><strong>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox1" runat="server" CssClass="auto-style8" Text="MARATHI" />
            </strong>&nbsp;<strong><asp:CheckBox ID="CheckBox2" runat="server" CssClass="auto-style8" Text="HINDI" />
            </strong>&nbsp;<strong><asp:CheckBox ID="CheckBox3" runat="server" CssClass="auto-style8" Text="TELGU" />
            </strong></span>
        </p>
        <p class="auto-style6">
            <strong><span class="auto-style12">STATE&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style9" Width="219px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            </strong>
        </p>
        <p class="auto-style6">
            <strong><span class="auto-style12">CITY&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="auto-style12" Width="219px">
            </asp:DropDownList>
            </strong>
        </p>
        <p class="auto-style6">
            <strong><span class="auto-style12">BLOOD GROUP&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:DropDownList ID="DropDownList3" runat="server" CssClass="auto-style12" Width="196px">
                <asp:ListItem>--Select Blood Group--</asp:ListItem>
                <asp:ListItem>A+</asp:ListItem>
                <asp:ListItem>A-</asp:ListItem>
                <asp:ListItem>B+</asp:ListItem>
                <asp:ListItem>B-</asp:ListItem>
                <asp:ListItem>O+</asp:ListItem>
                <asp:ListItem>O-</asp:ListItem>
                <asp:ListItem>AB+</asp:ListItem>
                <asp:ListItem>AB-</asp:ListItem>
            </asp:DropDownList>
            </strong>
        </p>
        <p class="auto-style6">
            <strong><span class="auto-style12">PHNO&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style12"></asp:TextBox>
            </strong>
        </p>
        <p class="auto-style6">
            <strong><span class="auto-style12">EMAIL&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style12" Width="198px"></asp:TextBox>
            <span class="auto-style12">&nbsp;</span></strong></p>
        <p class="auto-style15">
            <span class="auto-style16"><strong>REGISTER DATE&nbsp;&nbsp;&nbsp;&nbsp; </strong></span><strong>
            <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style12" OnTextChanged="TextBox6_TextChanged" TextMode="Date"></asp:TextBox>
            </strong>
        </p>
        <p class="auto-style15">
            <strong>
            <span class="auto-style16"><span class="auto-style8">NEW&nbsp; PASSWORD&nbsp;&nbsp;&nbsp;&nbsp; </span></span>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style12" TextMode="Password"></asp:TextBox>
            <span class="auto-style12">&nbsp;&nbsp; </span>
            </strong>
        </p>
        <p class="auto-style15">
            <strong>
            <span class="auto-style12">CONFIRM PASSWOR</span><asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style12" TextMode="Password"></asp:TextBox>
            </strong>
        </p>
        <p class="auto-style15">
            &nbsp;</p>
        <p class="auto-style15">
            <strong>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style10" Text="REGISTER" OnClick="Button1_Click" />
            <span class="auto-style12">&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:Button ID="Button2" runat="server" CssClass="auto-style10" Text="CLEAR" OnClick="Button2_Click" />
            </strong></p>
        <p class="auto-style6">
            <strong>
            <span class="auto-style12">ALREADY REGISTER ? </span>
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style12" NavigateUrl="~/USERLOGIN.aspx">LOGIN</asp:HyperLink>
            </strong>
        </p>
        <p class="auto-style6">
            <strong>---------------------------------------------------------------------------------------------------------------------------------------------</strong></p>
    </form>
</body>
</html>
