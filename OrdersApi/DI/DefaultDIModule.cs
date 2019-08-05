using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using OrdersApi.Service;
using OrdersApi.Service.Interface;
using Module = Autofac.Module;

namespace OrdersApi.DI
{
	public class DefaultDIModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			//Registration All repositories 
			builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
				.Where(t => t.Name.EndsWith("Repository"))
				.AsImplementedInterfaces();

			//Registration Base Functionality
			builder.RegisterType<BaseService>().As<IBaseService>();

			//Registration Services
			builder.RegisterType<OrderService>().As<IOrderService>().PropertiesAutowired();
		}
	}
}
