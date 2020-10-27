using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MediatR;
using System.Reflection;
using Newtonsoft.Json;
using Hangfire.Common;
using Hangfire.WebApi.Hangfire;
using System.Threading;
namespace Hangfire.WebApi
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
            services.AddHangfire(x => x.UseSqlServerStorage("Data Source=localhost;Initial Catalog=MediatRHangFire;User Id=test;Password=Test123!"));
            services.AddHangfireServer();
            services.AddMediatR(typeof(Startup));
            services.AddControllers();

            using (var server = new BackgroundJobServer())
            {
                BackgroundJob.Enqueue(() => HangfireHelpers.Send(new RequestCommand { Message = "Hello World!" }));

                Console.WriteLine($"Hangfire Server started on Thread {Thread.CurrentThread.ManagedThreadId}.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();
            app.UseHangfireDashboard();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


           // BackgroundJob.Enqueue<IMediator>(mediator => mediator.Send(new RequestCommand()));
        }
    }
}
