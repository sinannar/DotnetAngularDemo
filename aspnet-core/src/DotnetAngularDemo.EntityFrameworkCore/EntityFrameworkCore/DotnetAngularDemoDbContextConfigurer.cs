using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DotnetAngularDemo.EntityFrameworkCore
{
    public static class DotnetAngularDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DotnetAngularDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DotnetAngularDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
