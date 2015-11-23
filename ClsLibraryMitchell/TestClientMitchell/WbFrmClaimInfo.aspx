<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WbFrmClaimInfo.aspx.cs" Inherits="TestClientMitchell.WbFrmClaimInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
            width: 202px;
        }
        .auto-style2 {
            text-align: left;
            width: 350px;
        }
        .auto-style3 {
            text-align: right;
            width: 202px;
            height: 24px;
            color: #000000;
            font-weight: bold;
            background-color: #FFFFFF;
        }
        .auto-style4 {
            text-align: left;
            height: 24px;
            width: 350px;
        }
        .auto-style5 {
            height: 24px;
        }
        .auto-style6 {
            text-align: right;
            height: 18px;
            color: #000000;
            font-weight: bold;
            background-color: #FFFFFF;
            width: 202px;
        }
        .auto-style7 {
            text-align: left;
            width: 350px;
            height: 18px;
        }
        .auto-style8 {
            height: 18px;
        }
        .auto-style9 {
            text-align: right;
            width: 202px;
            color: #000000;
            font-weight: bold;
            background-color: #FFFFFF;
        }
        .auto-style10 {
            text-align: left;
            height: 18px;
            color: #000000;
            font-weight: bold;
            font-size: medium;
            text-decoration: underline;
            background-color: #FFFFFF;
        }
        .auto-style11 {
            text-align: right;
            width: 202px;
            height: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family: tahoma; font-size: 12px; text-align: center;">
    
        <br />
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style10" colspan="3">Claim Information<br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Claim Number:</td>
                <td class="auto-style7">
                    <asp:Label ID="lblClaimNumber" runat="server" style="font-weight: 700"></asp:Label>
                </td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style3">ClaimantFirstName:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtFirstName" runat="server" BackColor="#FFFFCC" Font-Names="Tahoma" Font-Size="12px"></asp:TextBox>
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style9">ClaimantLastName:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtLastName" runat="server" BackColor="#FFFFCC" Font-Names="Tahoma" Font-Size="12px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">Status:</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlStatus" runat="server" BackColor="#FFFFCC" Font-Names="Tahoma" Font-Size="12px">
                        <asp:ListItem>OPEN</asp:ListItem>
                        <asp:ListItem>CLOSE</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">LossDate[MM-DD-YYYY]:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtLossDateMM" runat="server" BackColor="#FFFFCC" Font-Names="Tahoma" Font-Size="12px" Width="30px"></asp:TextBox>
                    -<asp:TextBox ID="txtLossDateDD" runat="server" BackColor="#FFFFCC" Font-Names="Tahoma" Font-Size="12px" Width="30px"></asp:TextBox>
                    -<asp:TextBox ID="txtLossDateYYYY" runat="server" BackColor="#FFFFCC" Font-Names="Tahoma" Font-Size="12px" Width="30px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">CauseOfLoss:</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlCuaseOfLoss" runat="server" BackColor="#FFFFCC" Font-Names="Tahoma" Font-Size="12px">
                        <asp:ListItem>Collision</asp:ListItem>
                        <asp:ListItem>Explosion</asp:ListItem>
                        <asp:ListItem>Fire</asp:ListItem>
                        <asp:ListItem>Hail</asp:ListItem>
                        <asp:ListItem>MechanicalBreakdown</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">ReportedDate[MM-DD-YYYY]:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtReportDateMM" runat="server" BackColor="#FFFFCC" Font-Names="Tahoma" Font-Size="12px" Width="30px"></asp:TextBox>
                    -<asp:TextBox ID="txtReportDateDD" runat="server" BackColor="#FFFFCC" Font-Names="Tahoma" Font-Size="12px" Width="30px"></asp:TextBox>
                    -<asp:TextBox ID="txtReportDateYYYY" runat="server" BackColor="#FFFFCC" Font-Names="Tahoma" Font-Size="12px" Width="30px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">LossDescription:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtLossDesc" runat="server" BackColor="#FFFFCC" Font-Names="Tahoma" Font-Size="12px" TextMode="MultiLine" Width="338px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">AssignedAdjusterID:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAssignAdjID" runat="server" BackColor="#FFFFCC" Font-Names="Tahoma" Font-Size="12px" Width="129px"></asp:TextBox>
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style11"></td>
                <td class="auto-style7"></td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <table style="width:100%;">
            <tr>
                <td colspan="3" style="font-weight: 700; color: #000000; text-decoration: underline; background-color: #FFFFFF; text-align: left;">Vechicle Information<br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="gvVehicle" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
