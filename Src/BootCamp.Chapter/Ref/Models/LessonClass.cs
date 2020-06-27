using System.Collections.Generic;
using BootCamp.Chapter.Ref.Enums;
using BootCamp.Chapter.Ref.Repository.Interfaces;

namespace BootCamp.Chapter.Ref.Models
{
    public class LessonClass: IEntity
    {
        public uint Id { get; set; }
        public uint TeacherId { get; set; }
        public LessonSubject Subject { get; set; }
        public string Name { get; }
        public string Description { get; set; }
        public IList<Student> Students { get; set; }

        public LessonClass()
        {
            Students = new List<Student>();
        }

        public override string ToString()
        {
            return $"Id: {Id}, Subject: {Subject}, Name:{Name}, Description:{Description},";
        }
    }
}