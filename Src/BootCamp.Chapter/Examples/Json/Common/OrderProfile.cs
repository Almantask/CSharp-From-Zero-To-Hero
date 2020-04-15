using AutoMapper;
using JSON = BootCamp.Chapter.Examples.Json.Common.Models;

namespace BootCamp.Chapter.Examples.Json.Common
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<JSON.Item, Domain.Item>();
            CreateMap<JSON.Order, Domain.Order>();
            CreateMap<JSON.OrderHeader, Domain.OrderHeader>();
            CreateMap<JSON.OrderLine, Domain.OrderLine>();

            CreateMap<Domain.Item, JSON.Item>();
            CreateMap<Domain.Order, JSON.Order>();
            CreateMap<Domain.OrderHeader, JSON.OrderHeader>();
            CreateMap<Domain.OrderLine, JSON.OrderLine>();
        }
    }
}
