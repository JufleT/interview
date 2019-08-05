using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrdersApi.DTO;
using OrdersApi.Repository.Model;
using OrdersApi.Service.Interface;

namespace OrdersApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		private readonly IOrderService orderService;

		public OrdersController(IOrderService orderService)
		{
			this.orderService = orderService;
		}

		[HttpGet]
		public ActionResult<IEnumerable<OrderDto>> Get()
		{
			var orderDtos = orderService.GetAllOrders();
			return orderDtos.ToList();
		}

		[HttpGet("{id}")]
		public ActionResult<OrderDto> Get(long id)
		{
			return orderService.GetOrderById(id);
		}

		[HttpPut("{id}")]
		public void Put(int id, OrderDto dto)
		{
			orderService.UpdateOrder(id, dto);
		}

		[HttpPost]
		public ActionResult<OrderDto> Post(OrderDto dto)
		{
			return orderService.Create(dto);
		}
	}
}
