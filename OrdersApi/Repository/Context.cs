using Microsoft.EntityFrameworkCore;
using OrdersApi.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Repository
{
	public class Context : DbContext
	{
		public Context(DbContextOptions<Context> options) : base(options)
		{
			//Disable automigration
			//Database.Migrate();
		}

		// DB sets
		DbSet<Order> Orders { get; set; }
		DbSet<BillingAdress> BillingAddresses { get; set; }
		DbSet<Payment> Payments { get; set; }
		DbSet<Article> Articles { get; set; }
	}
}
