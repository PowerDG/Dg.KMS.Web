
using AutoMapper;
using DgKMS.Cube.CubeCore;
using DgKMS.Cube.CubeCore.Dtos;

namespace DgKMS.Cube.CustomDtoAutoMapper
{

	/// <summary>
    /// 配置EvernoteTag的AutoMapper映射
	/// 前往 <see cref="CubeApplicationModule"/>的AbpAutoMapper配置方法下添加以下代码段
    /// EvernoteTagDtoAutoMapper.CreateMappings(configuration);
    /// </summary>
	internal static class EvernoteTagDtoAutoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <EvernoteTag,EvernoteTagListDto>();
            configuration.CreateMap <EvernoteTagListDto,EvernoteTag>();

            configuration.CreateMap <EvernoteTagEditDto,EvernoteTag>();
            configuration.CreateMap <EvernoteTag,EvernoteTagEditDto>();
					 
							//// custom codes
									
							

							//// custom codes end
        }
	}
}
