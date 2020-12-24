using System;
using BootCamp.Chapter.Hints;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher<Math> like = new Teacher<Math>();
            like.ProduceMaterial();
            Console.WriteLine(like.Name);

            var yanan = new Student(123);
            yanan.LearnFrom<Teacher<Math>,Math>(like);

        }
    }
}
