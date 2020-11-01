<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckoutError.aspx.cs" Inherits="PayPal.CheckoutError" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			    <h1>Checkout Error</h1>
    <p></p>
	<table id="ErrorTable">
		<tr>
			<td class="field"></td>
			<td><%=Request.QueryString.Get("ErrorCode")%></td>
		</tr>
		<tr>
			<td class="field"></td>
			<td><%=Request.QueryString.Get("Desc")%></td>
		</tr>
		<tr>
			<td class="field"></td>
			<td><%=Request.QueryString.Get("Desc2")%></td>
		</tr>
	</table>
    <p></p>
        </div>
    </form>
</body>
</html>
