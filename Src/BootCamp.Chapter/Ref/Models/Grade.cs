using System;
using BootCamp.Chapter.Ref.Enums;
using BootCamp.Chapter.Ref.Repository.Interfaces;

namespace BootCamp.Chapter.Ref.Models
{
    public class Grade: IEntity
    {
        public uint Id { get; set; }
        public uint StudentId { get; set; }
        public LessonSubject Subject { get; set; }
        public DateTime DateTime { get; set; }
        public GradeEvaluation Evaluation { get; set; }
        public string Notes { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Subject: {Subject}, Date:{DateTime}, Evaluation:{Evaluation}," +
                   $"{System.Environment.NewLine}Notes:{Notes}";
        }
    }
}