using OrdersApi.DTO.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Repository.Model
{
	public class Order
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long OxId { get; set; }
		public DateTime OrderDatetime { get; set; }
		public int? InvoiceNumber { get; set; }
		public byte? OrderStatus { get; set; }

		public virtual BillingAdress BillingAdress { get; set; }
		public virtual ICollection<Payment> Payments { get; set; }
		public virtual ICollection<Article> Articles { get; set; }
	}
}
