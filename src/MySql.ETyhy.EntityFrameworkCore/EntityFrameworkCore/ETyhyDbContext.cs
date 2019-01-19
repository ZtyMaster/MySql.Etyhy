using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MySql.ETyhy.Authorization.Roles;
using MySql.ETyhy.Authorization.Users;
using MySql.ETyhy.MultiTenancy;
using MySql.ETyhy.ComPay;
using MySql.ETyhy.Bumen;
using MySql.ETyhy.ComPay.Bumen.ZhiWu;

namespace MySql.ETyhy.EntityFrameworkCore
{
    public class ETyhyDbContext : AbpZeroDbContext<Tenant, Role, User, ETyhyDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ETyhyDbContext(DbContextOptions<ETyhyDbContext> options)
            : base(options)
        {
        }
        public DbSet<Comas> Comass { get; set; }
        public DbSet<BuMens> BuMenss { get; set; }
        public DbSet<Zhiws> Zhiwss { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Comas>().ToTable("Comas", "Yhy");
            //modelBuilder.Entity<BuMens>().ToTable("BuMens", "Yhy");
            //modelBuilder.Entity<Zhiws>().ToTable("Zhiws", "Yhy");
            base.OnModelCreating(modelBuilder);
        }
    }
}
