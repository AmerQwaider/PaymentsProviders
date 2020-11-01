﻿using System;

namespace PayPal
{
	public class Order
	{

		public DateTime OrderDate { get; set; }
		public int OrderId { get; set; }
		public string Username { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Quantity { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }
		public string Email { get; set; }
		public decimal Total { get; set; }

	}
}
