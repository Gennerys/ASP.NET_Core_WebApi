using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using NekoMarket.API.Domain.Repositories;
using NekoMarket.API.Domain.Services;
using NekoMarket.API.Persistence.Contexts;
using NekoMarket.API.Persistence.Repositories;
using NekoMarket.API.Services;
using AutoMapper;
using System;

namespace NekoMarket.API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<AppDbContext>(options => {
                options.UseInMemoryDatabase("nekomarket-api-in-memory");
            }); //поменять потом на sql

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //OR
            //services.AddAutoMapper(typeof(Startup));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
