
using AutoMapper;
using Dg.KMS.People;
using Dg.KMS.People.Dtos;

namespace Dg.KMS.People.Mapper
{

	/// <summary>
    /// 配置Person的AutoMapper
    /// </summary>
	internal static class PersonMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <Person,PersonListDto>();
            configuration.CreateMap <PersonListDto,Person>();

            configuration.CreateMap <PersonEditDto,Person>();
            configuration.CreateMap <Person,PersonEditDto>();

        }
	}
}
