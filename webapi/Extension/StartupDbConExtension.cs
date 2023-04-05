using Microsoft.EntityFrameworkCore;
using System;
using Chat.WebApi;
using Chat.Data;

namespace Chat.WebApi.Extension
{
    public static class StartupDbContextExtension
    {
        public static void AddDbContextDI(this IServiceCollection services, IConfiguration configuration)
        {

            var dbConfig = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppDbContext>(options => options
               .UseSqlServer(dbConfig)
               );


        }


    }
}
