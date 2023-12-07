using System;
namespace Inventory.Models
{
	public class Part
	{
		public int ID { set; get; }
        public string Description { set; get; }
        public float Price { set; get; }
        public int Quantity { set; get; }

		public Part(int id, string description, float price, int quantity)
		{
			this.ID = id;
			this.Description = description;
			this.Price = price;
			this.Quantity = quantity;
		}
	}
}

