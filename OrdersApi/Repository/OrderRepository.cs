using Microsoft.EntityFrameworkCore;
using OrdersApi.Repository.Interface;
using OrdersApi.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Repository
{
	public class OrderRepository : BaseRepository<Order>, IOrderRepository
	{
		public OrderRepository(Context dbContext) : base(dbContext)
		{
		}
	}
	
}
