<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WbFromShowData.aspx.cs" Inherits="TestClientMitchell.WbFromShowData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            font-size: large;
        }
        .auto-style2 {
            text-align: left;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style2" style="font-family: Tahoma; font-size: 12px; text-align: left;">
    
        <div class="auto-style2">
            <br />
        <span class="auto-style1"><strong style="text-align: center">Recruiting: Coding Exercise<br />
        Mitchell International</strong></span><br />
        </div>
        <br />
        <br />
                    <asp:GridView ID="gvClaimData" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" style="text-align: left" OnRowCommand="gvClaimData_RowCommand1"  >
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="ClaimNumber" HeaderText="Claim #" />
                            <asp:BoundField DataField="ClaimantFirstName" HeaderText="FirstName" />
                            <asp:BoundField DataField="ClaimantLastName" HeaderText="LastName" />
                            <asp:BoundField DataField="Status" HeaderText="Status" />
                            <asp:BoundField DataField="LossDate" HeaderText="LossDate" />
                            <asp:BoundField DataField="CauseOfLoss" HeaderText="CauseOfLoss" />
                            <asp:BoundField DataField="ReportedDate" HeaderText="ReportedDate" />
                            <asp:BoundField DataField="LossDescription" HeaderText="LossDescription" />
                            <asp:BoundField DataField="AssignedAdjusterID" HeaderText="AssignedAdjusterID" />
                            <asp:ButtonField CommandName="det" HeaderText="Details/Update" Text="Details/Update" />
                            <asp:ButtonField CommandName="del" HeaderText="Delete" Text="Delete" />
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
