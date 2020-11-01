<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckoutComplete.aspx.cs" Inherits="PayPal.CheckoutComplete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<h1>Checkout Complete</h1>
			<p></p>
			<h3>Payment Transaction ID:</h3>
			<asp:Label ID="TransactionId" runat="server"></asp:Label>
			<p></p>
			<h3>Thank You!</h3>
			<p></p>
			<hr />
		</div>
	</form>
</body>
</html>
