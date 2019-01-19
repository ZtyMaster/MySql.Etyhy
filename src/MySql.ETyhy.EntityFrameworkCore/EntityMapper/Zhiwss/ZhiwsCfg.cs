

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.ETyhy.ComPay.Bumen.ZhiWu;

namespace MySql.ETyhy.EntityMapper.Zhiwss
{
    public class ZhiwsCfg : IEntityTypeConfiguration<Zhiws>
    {
        public void Configure(EntityTypeBuilder<Zhiws> builder)
        {

            builder.ToTable("Zhiwss", YoYoAbpefCoreConsts.SchemaNames.CMS);

            
			builder.Property(a => a.TName).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.BumensId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.Bumens).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.Shot).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);


        }
    }
}


