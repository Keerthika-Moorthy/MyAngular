using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInformation
{
    public static class CustomExtensions
    {
        public static IServiceCollection AddServerDatabase(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDbConnection>(sp => new SqlConnection(configuration.GetConnectionString("server = (localdb)\\MSSQLLocalDB ; Database = PracticeDB; User Id = CTS/805901")));
            return services;
        }
    }
}
