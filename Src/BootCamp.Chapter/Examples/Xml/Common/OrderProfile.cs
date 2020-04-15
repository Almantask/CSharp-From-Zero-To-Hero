using AutoMapper;
using BootCamp.Chapter.Examples.Domain;
using XML = BootCamp.Chapter.Examples.Xml.Common.Models;

namespace BootCamp.Chapter.Examples.Xml.Common
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<XML.Item, Domain.Item>()
                .ConstructUsing(item => new Domain.Item(item.Nam, item.Description, item.DataOfMaking));

            CreateMap<XML.Order, Domain.Order>();
            CreateMap<XML.OrderHeader, Domain.OrderHeader>();
            CreateMap<XML.OrderLine, Domain.OrderLine>();

            CreateMap<Domain.Item, XML.Item>()
                .ConstructUsing(item => new XML.Item
                {
                    Nam = item.Name,
                    Description = item.Description,
                    DataOfMaking = item.DataOfMaking
                });

            CreateMap<Domain.Order, XML.Order>();
            CreateMap<Domain.OrderHeader, XML.OrderHeader>();
            CreateMap<Domain.OrderLine, XML.OrderLine>();
        }
    }
}
