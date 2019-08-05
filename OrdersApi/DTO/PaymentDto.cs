using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrdersApi.DTO
{
	public class PaymentDto
	{
		[XmlElement(ElementName = "method-name")]
		public string MethodName { get; set; }

		[XmlElement(ElementName = "amount")]
		public decimal Amount { get; set; }
	}
}
