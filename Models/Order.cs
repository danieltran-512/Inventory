using System;
namespace Inventory.Models
{
	public class Order
	{
		public List<LineItem> LineItems { get; set; }
		public float TotalCost { get; set; }
		public Order(List<LineItem> lineItems)
		{
			this.LineItems = lineItems;

			float cost = 0;
			lineItems.ForEach(item => cost += item.Cost);

			this.TotalCost = cost;

		}
	}
}

