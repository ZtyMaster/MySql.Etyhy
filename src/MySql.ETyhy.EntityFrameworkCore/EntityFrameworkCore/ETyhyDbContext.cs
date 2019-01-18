using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MySql.ETyhy.Authorization.Roles;
using MySql.ETyhy.Authorization.Users;
using MySql.ETyhy.MultiTenancy;

namespace MySql.ETyhy.EntityFrameworkCore
{
    public class ETyhyDbContext : AbpZeroDbContext<Tenant, Role, User, ETyhyDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ETyhyDbContext(DbContextOptions<ETyhyDbContext> options)
            : base(options)
        {
        }
    }
}
