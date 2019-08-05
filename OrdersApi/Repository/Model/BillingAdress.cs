using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Repository.Model
{
	public class BillingAdress
	{
		[Key]
		public int Id { get; set; }
		public string Email { get; set; }
		public string Fullname { get; set; }
		public string Street { get; set; }
		public short HomeNumber { get; set; }
		public string City { get; set; }
		public int Zip { get; set; }
		public string Country { get; set; }

		[ForeignKey("Order")]
		public long OrderOxId { get; set; }
		public virtual Order Order { get; set; }
	}
}
