

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.ETyhy.ComPay;

namespace MySql.ETyhy.EntityMapper.Comass
{
    public class ComasCfg : IEntityTypeConfiguration<Comas>
    {
        public void Configure(EntityTypeBuilder<Comas> builder)
        {

            builder.ToTable("Comass", YoYoAbpefCoreConsts.SchemaNames.CMS);

            
			builder.Property(a => a.TName).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.OverTime).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.MaxPersons).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.BuMens).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.Users).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);


        }
    }
}


