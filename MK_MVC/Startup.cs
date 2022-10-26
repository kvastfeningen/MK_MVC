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
using Microsoft.OpenApi.Models;

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

			services.AddCors(options =>
			{
				//options.AddPolicy(name: "AllowReact",
                options.AddDefaultPolicy(
                        policy =>
						{

							policy.WithOrigins("*")
							//.AllowAnyHeader()
                           // .AllowAnyMethod()
                            ;
							
                        });
			});
            
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
            services.AddControllers();

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
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseDefaultFiles();
            app.UseStaticFiles();

			app.UseRouting();

			//testar med denna
            //app.UseRequestLocalization();

            //app.UseCors("AllowReact");
            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials());

            app.UseAuthentication();
			app.UseAuthorization();

			app.UseSession();

			//testar att ta med dessa
            //app.UseResponseCompression();
            //app.UseResponseCaching();

            /*
            // Add Access Control Allow Origin headers
            app.use((req, res, next) => {
                res.setHeader("Access-Control-Allow-Origin", "*");
                res.header(
                  "Access-Control-Allow-Headers",
                  "Origin, X-Requested-With, Content-Type, Accept"
                );
                next();
            });
			*/
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
