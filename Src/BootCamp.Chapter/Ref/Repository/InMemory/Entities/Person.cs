using BootCamp.Chapter.Ref.Repository.Interfaces;

namespace BootCamp.Chapter.Ref.Repository.InMemory.Entities
{
    public class Person: IEntity
    {
        public string Name { get; set; }
        public string Surename { get; set; }
        public int Age { get; set; }
        public uint Id { get; set; }
    }
}
