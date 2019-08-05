using OrdersApi.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Repository.Interface
{
	public interface IOrderRepository : IBaseRepository<Order>
	{
	}
}
