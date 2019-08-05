using OrdersApi.DTO;
using OrdersApi.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Service.Interface
{
	public interface IOrderService
	{
		IEnumerable<OrderDto> GetAllOrders();
		OrderDto GetOrderById(long id);
		void UpdateOrder(long id, OrderDto dto);
		OrderDto Create(OrderDto dto);
	}
}
