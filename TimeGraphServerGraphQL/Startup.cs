using HotChocolate;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TimeGraphServerGraphQL.Database;
using TimeGraphServerGraphQL.GraphQL;

namespace TimeGraphServerGraphQL
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TimeGraphContext>(context =>
            {
                context.UseInMemoryDatabase("TimeGraphServer");
            });

            services.AddGraphQLServer()
                    .RegisterDbContext<TimeGraphContext>()
                    .AddQueryType<Query>();

            //services.AddGraphQL(provider => SchemaBuilder.New().AddServices(provider)
            //    .AddType<ProjectType>()
            //    .AddType<TimeLogType>()
            //    .AddQueryType<Query>()
            //    .Create());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UsePlayground(new PlaygroundOptions
                //{
                //    QueryPath = "/api",
                //    Path = "/playground"
                //});
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}
