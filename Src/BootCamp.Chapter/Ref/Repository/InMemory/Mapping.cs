namespace BootCamp.Chapter.Ref.Repository.InMemory
{
    public static class Mapping
    {
        public static IMapper Mapper;

        static Mapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Entities.Student, Models.Student>();
                cfg.CreateMap<Entities.Grade, Models.Grade>();
                cfg.CreateMap<Entities.LessonClass, Models.LessonClass>();
                cfg.CreateMap<Entities.Person, Models.Person>();
                cfg.CreateMap<Entities.Teacher, Models.Teacher>();
            });

            Mapper = config.CreateMapper();
        }
    }
}
