

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.ETyhy.Bumen;

namespace MySql.ETyhy.EntityMapper.BuMenss
{
    public class BuMensCfg : IEntityTypeConfiguration<BuMens>
    {
        public void Configure(EntityTypeBuilder<BuMens> builder)
        {

            builder.ToTable("BuMenss", YoYoAbpefCoreConsts.SchemaNames.CMS);

            
			builder.Property(a => a.TName).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.IsTopBm).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.ComasId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.Comas).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.Zhiws).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.Shot).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);


        }
    }
}


