using System.Globalization;
using AutoMapper;
using EcommerceSW.Data;
using EcommerceSW.Domain;
using EcommerceSW.Service;
using EcommerceSW.Service.Contracts;
using EcommerceSW.Web.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace EcommerceSW.Web
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
            services.AddControllersWithViews();
            
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IPromocaoService, PromocaoService>();
            services.AddScoped<ICarrinhoService, CarrinhoService>();
            services.AddScoped<ICarrinhoRepository, CarrinhoRepository>();
            services.AddLogging();

            var configurations = new Configuration();
            new ConfigureFromConfigurationOptions<Configuration>(
                Configuration.GetSection("PathDataBase"))
                    .Configure(configurations);
            services.AddSingleton(configurations);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProdutoViewModel, Produto>();
            });
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            
            var cultureInfo = new CultureInfo("pt-br");
            cultureInfo.NumberFormat.CurrencySymbol = "R$";

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
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
