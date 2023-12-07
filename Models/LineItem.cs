using System;
namespace Inventory.Models
{
	public class LineItem
	{
		public Part Part { get; set; }
		public float Cost { get; set; }
		public LineItem(Part part)
		{
			this.Part = part;
			this.Cost = part.Quantity * part.Price;
        }
    }
}

