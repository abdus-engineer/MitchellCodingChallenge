<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WbFrmHome.aspx.cs" Inherits="TestClientMitchell.WbFrmHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
 p.MsoNormal
	{margin-bottom:.0001pt;
	font-size:11.0pt;
	font-family:"Calibri","sans-serif";
	        margin-left: 0in;
            margin-right: 0in;
            margin-top: 0in;
        }
a:link
	{color:blue;
	text-decoration:underline;
	text-underline:single;
        }
    </style>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
    <div style="font-family: tahoma; font-size: 12px; text-align: left;">
    
        <br />
        <span class="auto-style1"><strong>Recruiting: Coding Exercise<br />
        Mitchell International<br />
        </strong></span>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <table style="width: 100%; font-family: tahoma; font-size: 11px;">
            <tr>
                <td>&nbsp;</td>
                <td style="font-family: tahoma; font-size: 12px">
                    <asp:Button ID="Button2" runat="server" Font-Names="Tahoma" Font-Size="12px" OnClick="Button2_Click" Text="Test Database" Width="300px" Height="50px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="font-family: tahoma; font-size: 12px">
                    <asp:Button ID="Button1" runat="server" Font-Names="Tahoma" Font-Size="12px" OnClick="Button1_Click" Text="Create Claim Using create-claim.xml" Width="300px" Height="50px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="font-family: tahoma; font-size: 12px">
                    <asp:Button ID="Button3" runat="server" Font-Names="Tahoma" Font-Size="12px" OnClick="Button3_Click" Text="Update Claim Using update-claim.xml" Width="300px" Height="50px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="font-family: tahoma; font-size: 12px">
                    <asp:Button ID="Button6" runat="server" Font-Names="Tahoma" Font-Size="12px" OnClick="Button6_Click" Text="Show/Delete Claims" Width="300px" Height="50px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        Developed By:<br />
        <br />
        <strong>Abdus Sakur</strong><p class="MsoNormal">
            <span style="font-size:9.0pt;font-family:&quot;Tahoma&quot;,&quot;sans-serif&quot;">| Graduate Assistant- Computer Science | University of Bridgeport, CT 06604, USA |<o:p></o:p></span></p>
        <p class="MsoNormal">
            <span style="font-size:9.0pt;font-family:&quot;Tahoma&quot;,&quot;sans-serif&quot;">| P: +1 (203) 543 0665 | E: <a href="mailto:abdus.engineer@gmail.com">abdus.engineer@gmail.com</a>, <a href="mailto:asakur@my.bridgeport.edu">asakur@my.bridgeport.edu</a> |<o:p> LinkdedIn: <a href="https://www.linkedin.com/in/abdus-sakur-944043101">https://www.linkedin.com/in/abdus-sakur-944043101</a> |</o:p></span></p>
        <p class="MsoNormal">
            <o:p></o:p>
        </p>
        <p class="MsoNormal">
            <span style="font-size:9.0pt;font-family:&quot;Tahoma&quot;,&quot;sans-serif&quot;"><o:p>&nbsp;</o:p></span></p>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
