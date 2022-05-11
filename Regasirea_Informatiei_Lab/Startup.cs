using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Regasirea_Informatiei_Lab.DAL.Interfaces;
using Regasirea_Informatiei_Lab.DAL.Repositories;
using Regasirea_Informatiei_Lab.Filter;
using Regasirea_Informatiei_Lab.Models;
using Regasirea_Informatiei_Lab.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IGenericRepository<Category>, GenericRepository<Category>>();
            services.AddScoped<ICategoryServices, CategoryServices>();


            services.AddScoped<IGenericRepository<Product>, GenericRepository<Product>>();
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ShoppingCart>(sc => ShoppingCart.GetCart(sc));

            services.AddScoped<IGenericRepository<Contact>, GenericRepository<Contact>>();
            services.AddScoped<IContactService, ContactService>();

            services.AddScoped<IGenericRepository<Blog>, GenericRepository<Blog>>();
            services.AddScoped<IBlogServices, BlogServices>();

            services.AddScoped<IGenericRepository<Subcategorie>, GenericRepository<Subcategorie>>();
            services.AddScoped<ISubcategoryServices, SubcategoryService>();

            //services.AddScoped<IOrderService, OrderService>();
            //services.AddScoped<ShoppingCart>(sc => ShoppingCart.GetCart(sc));
            //services.AddScoped<Wishlist>(sc => Wishlist.GetWishlist(sc));


            services.AddHttpContextAccessor();
            services.AddSession();
            services.AddRazorPages();

            services.AddDbContext<DBContext>
                (options => options.UseLazyLoadingProxies().UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews();

            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.SignIn.RequireConfirmedAccount = false;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            }).AddEntityFrameworkStores<DBContext>();
            services.AddControllersWithViews(options => {
                options.Filters.Add(typeof(UserFilterAttribute));
            });
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();


            app.UseAuthentication();
            app.UseRouting();


            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
