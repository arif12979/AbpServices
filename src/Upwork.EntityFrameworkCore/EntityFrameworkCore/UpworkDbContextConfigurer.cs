using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Upwork.EntityFrameworkCore
{
    public static class UpworkDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<UpworkDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<UpworkDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
