using Challange.Services.Detail.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challange.Services.Detail
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var featureService = serviceProvider.GetRequiredService<IFeatureService>();
                if (!featureService.GetAllAsync().Result.Data.Any())
                {
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                    featureService.CreateAsync(new Dtos.FeatureDto { Color="Mavi",CreatedDate=DateTime.Now,Disk="150GB",ProdId="123564",Ram="16",Size="M",WarrantyPeriod="24" }).Wait();
                }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
