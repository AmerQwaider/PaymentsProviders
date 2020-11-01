using System;
using System.Web.UI;

namespace PayPal
{
	public partial class CheckOut : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}


		protected void CheckoutBtn_Click(object sender, ImageClickEventArgs e)
		{

			//	Session["payment_amt"] = usersShoppingCart.GetTotal();
			Session["payment_amt"] = "5";
			Response.Redirect("CheckoutStart.aspx");
		}
	}
}