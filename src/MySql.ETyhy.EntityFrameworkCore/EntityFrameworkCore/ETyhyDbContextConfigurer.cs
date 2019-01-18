using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MySql.ETyhy.EntityFrameworkCore
{
    public static class ETyhyDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ETyhyDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ETyhyDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
