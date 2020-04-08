

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DgKMS.Cube.CubeCore;

namespace DgKMS.Cube.EntityMapper.EvernoteTags
{
    public class EvernoteTagCfg : IEntityTypeConfiguration<EvernoteTag>
    {
        public void Configure(EntityTypeBuilder<EvernoteTag> builder)
        {

			 
      //   builder.ToTable("EvernoteTags", YoYoAbpefCoreConsts.SchemaNames.CMS);
        builder.ToTable("EvernoteTags");

            //可以自定义配置参数内容
			
							//// custom codes
									
							

							//// custom codes end
        }
    }
}


