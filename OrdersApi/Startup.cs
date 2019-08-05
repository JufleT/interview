using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrdersApi.DI;
using OrdersApi.Repository;
using System;

namespace OrdersApi
{
	public class Startup
	{
		public IConfiguration Configuration { get; }
		private static IContainer Container { get; set; }


		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public IServiceProvider ConfigureServices(IServiceCollection services)
		{

			var builder = new ContainerBuilder();
			//Connection To DB
			string connection = Configuration.GetConnectionString("DefaultConnection");

			services.AddDbContext<Context>(options => options.UseLazyLoadingProxies().UseSqlServer(connection));
			services.AddAutoMapper(typeof(Startup));

			services.AddMvc(option =>
			{
				option.Filters.Add(new ProducesAttribute("application/xml"));
			})
				.AddXmlSerializerFormatters()
				.SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

			builder.RegisterModule<DefaultDIModule>();

			builder.Populate(services);
			Container = builder.Build();

			return new AutofacServiceProvider(Container);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseMvc();
		}
	}
}
