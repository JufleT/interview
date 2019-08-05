using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Repository.Model
{
	public class Article
	{
		[Key]
		public int Id { get; set; }
		public long Nomenclature { get; set; }
		public string Title { get; set; }
		public int Amount { get; set; }
		public double BrutPrice { get; set; }

		[ForeignKey("Order")]
		public long OrderOxId { get; set; }
		public virtual Order Order { get; set; }
	}
}
