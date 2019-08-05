using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrdersApi.DTO
{
	public class BillingAdressDto
	{
		[XmlElement(ElementName = "billemail")]
		public string Email { get; set; }

		[XmlElement(ElementName = "billfname")]
		public string Fullname { get; set; }

		[XmlElement(ElementName = "billstreet")]
		public string Street { get; set; }

		[XmlElement(ElementName = "billstreetnr")]
		public int HomeNumber { get; set; }

		[XmlElement(ElementName = "billcity")]
		public string City { get; set; }

		[XmlElement(ElementName = "country")]
		public CountryDto Country { get; set; }

		[XmlElement(ElementName = "billzip")]
		public int Zip { get; set; }
	}

	public class CountryDto
	{
		[XmlElement(ElementName = "geo")]
		public string Geo { get; set; }
	}
}
