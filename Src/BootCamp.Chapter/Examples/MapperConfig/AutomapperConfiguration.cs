using AutoMapper;
using JSON = BootCamp.Chapter.Examples.Json.Common;
using XML = BootCamp.Chapter.Examples.Xml.Common;

namespace BootCamp.Chapter.Examples.MapperConfig
{
    public static class AutomapperConfiguration
    {
        public static IMapper Setup() => new Mapper(new MapperConfiguration(Configure));

        private static void Configure(IMapperConfigurationExpression config)
        {
            config.AddProfile(new JSON.OrderProfile());
            config.AddProfile(new XML.OrderProfile());
        }
    }
}
