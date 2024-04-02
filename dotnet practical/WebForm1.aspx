<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="p26.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 824px;
            height: 848px;
        }
        .auto-style2 {
            width: 92%;
            height: 221px;
        }
        .auto-style3 {
            width: 180px;
        }
        .auto-style4 {
            width: 180px;
            height: 34px;
        }
        .auto-style5 {
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <h1>Student Registration Form </h1>
        <div class="auto-style1">
            <table class="auto-style2">
                <tr>
                    <td colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="Enter Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Name" runat="server" Height="20px" Width="175px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Name" Display="Dynamic" ErrorMessage="Please Provide Name" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label2" runat="server" Text="Enter Your Email"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="Email" runat="server" Height="20px" Width="175px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Email" Display="Dynamic" ErrorMessage="Please Provide Email" SetFocusOnError="True">*</asp:RequiredFieldValidator>
&nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Email" Display="Dynamic" ErrorMessage="Please Provide Vaild Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label3" runat="server" Text="Confirm Email"></asp:Label>
                    </td>
                    <td id="Confirm_Email" class="auto-style5">
                        <asp:TextBox ID="Confrim_Email" runat="server" Height="20px" Width="175px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Confrim_Email" Display="Dynamic" ErrorMessage="Please enter your email again" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label4" runat="server" Text="Class"></asp:Label>
                    </td>
                    <td id="Class" class="auto-style5">
                        <asp:TextBox ID="Class" runat="server" Height="20px" Width="175px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Class" Display="Dynamic" ErrorMessage=" Please provide class ">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Class" Display="Dynamic" ErrorMessage="Class Should be between 1-12" MaximumValue="12" MinimumValue="1">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label5" runat="server" Text=" What is your Genda"></asp:Label>
                    </td>
                    <td id="Female">
                        <asp:RadioButton ID="Male" runat="server" GroupName="Gender" Text="Male" />
&nbsp;&nbsp;
                        <asp:RadioButton ID="Female" runat="server" GroupName="Gender" Text="Female" />
                        <asp:RadioButton ID="Mechanic" runat="server" GroupName="Gender" Text="Mechanic" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Submit" runat="server" Height="25px" OnClick="Button1_Click" Text="Submit" Width="362px" />
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Please select one gender" OnServerValidate="CustomValidator1_ServerValidate">*</asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
