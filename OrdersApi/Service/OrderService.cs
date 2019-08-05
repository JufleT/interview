using OrdersApi.DTO;
using OrdersApi.Repository.Interface;
using OrdersApi.Repository.Model;
using OrdersApi.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrdersApi.Service
{
	public class OrderService : BaseService, IOrderService
	{
		private readonly IOrderRepository orderRepository;

		public OrderService(IOrderRepository orderRepository)
		{
			this.orderRepository = orderRepository;
		}

		public IEnumerable<OrderDto> GetAllOrders()
		{
			var orders = orderRepository.GetAll();

			var ordesDtoList = new List<OrderDto>();

			orders.ToList().ForEach(order =>
			{
				ordesDtoList.Add(Mapper.Map<Order, OrderDto>(order));
			});

			return ordesDtoList;
		}

		public OrderDto GetOrderById(long id)
		{
			var order = orderRepository.FindById(id);
			if (order == null) throw new Exception("Order wasn't found");

			return Mapper.Map<Order,OrderDto>(order);
		}

		public void UpdateOrder(long id, OrderDto dto)
		{
			var order = orderRepository.FindById(id);
			if (order == null) throw new Exception("Order wasn't found");

			if (dto.InvoiceNumber != null)
				order.InvoiceNumber = dto.InvoiceNumber;

			if (dto.OrderStatus.HasValue)
				order.OrderStatus = (byte)dto.OrderStatus;

			orderRepository.Update(order);
		}

		public OrderDto Create(OrderDto dto)
		{
			var entityOrder = Mapper.Map<OrderDto, Order>(dto);

			//There is no autoincrement for OxId, So i used maximum value from database
			// Or i can add this autoincrement for success inserting new value (not big deal)
			entityOrder.OxId = GetNextId();
			orderRepository.Create(entityOrder);

			return Mapper.Map<Order, OrderDto>(orderRepository.FindById(entityOrder.OxId));
		}

		private long GetNextId()
		{
			return orderRepository.GetAll().Max(x => x.OxId) + 1;
		}
	}
}
