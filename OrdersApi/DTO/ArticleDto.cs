using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrdersApi.DTO
{
	public class ArticleDto
	{
		[XmlElement(ElementName = "artnum")]
		public long Nomenclature { get; set; }

		[XmlElement(ElementName = "title")]
		public string Title { get; set; }

		[XmlElement(ElementName = "amount")]
		public int Amount { get; set; }

		[XmlElement(ElementName = "brutprice")]
		public double BrutPrice { get; set; }
	}
}
