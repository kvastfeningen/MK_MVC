using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MK_MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MK_MVC.Models;
using Microsoft.AspNetCore.Identity;

namespace MK_MVC
{
	public class Startup
	{
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		private readonly IConfiguration Configuration;

		public Startup(IConfiguration config)
        {
			Configuration = config;
        }
		
		
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
		
			services.AddSession(options =>
			{
				options.IdleTimeout = TimeSpan.FromMinutes(10);
				options.Cookie.HttpOnly = true;
				options.Cookie.IsEssential = true;
			});
			services.AddDbContext<ApplicationDbContext>(options =>
			options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

			services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
				.AddDefaultUI()
				.AddDefaultTokenProviders()
				.AddEntityFrameworkStores<ApplicationDbContext>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseSession();

			app.UseEndpoints(endpoints =>

			{

				endpoints.MapControllerRoute(
					name: "ajax",
					 pattern: "Ajax",
					defaults: new { controller = "Ajax", action = "Index" }

				);

				endpoints.MapControllerRoute(
				name: "person",
				 pattern: "Person",
				defaults: new { controller = "Person", action = "Index" }

			);

			
				endpoints.MapControllerRoute(
					name: "guessnumber",
					 pattern: "GuessNumber",
					defaults: new { controller = "Number", action = "GuessNumber" }

				);
			
				endpoints.MapControllerRoute(
					name: "feverCheck",
					 pattern: "FeverCheck",
					defaults: new { controller = "Doctor", action = "FeverCheck" }

			);
			 
			endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}"
					);
				endpoints.MapRazorPages();  
		});
			
		}
	}
}
