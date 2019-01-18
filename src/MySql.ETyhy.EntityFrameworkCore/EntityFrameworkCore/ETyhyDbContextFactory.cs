using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MySql.ETyhy.Configuration;
using MySql.ETyhy.Web;

namespace MySql.ETyhy.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ETyhyDbContextFactory : IDesignTimeDbContextFactory<ETyhyDbContext>
    {
        public ETyhyDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ETyhyDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ETyhyDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ETyhyConsts.ConnectionStringName));

            return new ETyhyDbContext(builder.Options);
        }
    }
}
