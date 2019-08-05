
using OrdersApi.DTO.Enum;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace OrdersApi.DTO
{
	[XmlRoot("order"), XmlType("order")]
	public class OrderDto
	{
		[XmlElement(ElementName = "oxid")]
		public long? OxId { get; set; }

		[XmlElement(ElementName = "orderdate")]
		public DateTime OrderDate { get; set; }

		[XmlElement(ElementName = "invoicenumber")]
		public int? InvoiceNumber { get; set; }

		[XmlElement(ElementName = "orderstatus")]
		public EOrderStatus? OrderStatus{ get; set; }

		[XmlElement(ElementName = "billingadress")]
		public BillingAdressDto BillingAdress { get; set; }

		[XmlElement(ElementName = "payments")]
		public List<PaymentDto> Payments { get; set; }

		[XmlElement(ElementName = "articles")]
		public List<ArticleDto> Articles { get; set; }
	}
}
