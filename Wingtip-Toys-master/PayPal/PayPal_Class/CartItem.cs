public class CartItem
{
	internal int OrderId;
	internal string Username;
	internal object ProductId;

	public string ProductName { get; set; }
	public string UnitPrice { get; set; }
	public string Quantity { get; set; }
}
