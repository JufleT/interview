using AutoMapper;
using OrdersApi.DTO;
using OrdersApi.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Mapper
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			CreateMap<Order, OrderDto>()
				.ForMember(x => x.OrderDate, opt => opt.MapFrom(expression => expression.OrderDatetime))
				.ForMember(x => x.InvoiceNumber, opt => opt.MapFrom(expression => expression.InvoiceNumber))
				.IncludeAllDerived().ReverseMap();

			CreateMap<BillingAdress, BillingAdressDto>()
				.ForPath(dest => dest.Country.Geo, opts => opts.MapFrom(expression=>expression.Country))
				.IncludeAllDerived()
				.ReverseMap();

			CreateMap<Payment, PaymentDto>().ReverseMap();
			CreateMap<Article, ArticleDto>().ReverseMap();
		}
	}
}