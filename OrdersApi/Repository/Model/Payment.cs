using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Repository.Model
{
	public class Payment
	{
		[Key]
		public int Id { get; set; }
		public string MethodName { get; set; }
		public decimal Amount { get; set; }

		[ForeignKey("Order")]
		public long OrderOxId { get; set; }
		public virtual Order Order { get; set; }
	}
}
