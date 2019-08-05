using AutoMapper;
using OrdersApi.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Service
{
	public class BaseService : IBaseService
	{
		public IMapper Mapper { get; set; }
	}
}
