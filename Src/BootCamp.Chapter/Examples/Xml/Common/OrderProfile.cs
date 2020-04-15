using AutoMapper;
using XML = BootCamp.Chapter.Examples.Xml.Common.Models;

namespace BootCamp.Chapter.Examples.Xml.Common
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<XML.Item, Domain.Item>();
            CreateMap<XML.Order, Domain.Order>();
            CreateMap<XML.OrderHeader, Domain.OrderHeader>();
            CreateMap<XML.OrderLine, Domain.OrderLine>();

            CreateMap<Domain.Item, XML.Item>();
            CreateMap<Domain.Order, XML.Order>();
            CreateMap<Domain.OrderHeader, XML.OrderHeader>();
            CreateMap<Domain.OrderLine, XML.OrderLine>();
        }
    }
}
