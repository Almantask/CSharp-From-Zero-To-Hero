using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstAssignment();
            SecondAssignment();
            ThirdAssignment();

            Console.ReadKey();
        }

        private static void ThirdAssignment()
        {
            /*
            * 
            3) Create any collection of any elements you want and do a demo for LINQ:  
            Any
            Count
            Order
            Sets
            Union
            Intersection
            Subtraction
            * 
            */

            Student a = new Student("John", 1);
            Student b = new Student("Mark", 2);
            Student c = new Student("Annie", 3);
            Student d = new Student("Marston", 4);

            List<Student> studentList = new List<Student>() { a, d, c, b };
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6 };

            ///<summary>
            /// Linq.Any()
            /// </summary>
            bool checkNamesForSpecificLetters = studentList.Any(s => s.Name.Contains('z'));
            Console.WriteLine(checkNamesForSpecificLetters);

            ///<summary>
            /// Linq.Count()
            /// </summary>
            int counter = intList.Count(n => n > 2);
            Console.WriteLine($"There are {counter} numbers that match this predicate");

            ///<summary>
            /// Linq.OrderBy()
            ///</summary>
            ///
            List<Student> newStudentList = new List<Student>();
            newStudentList = studentList.OrderBy(n => n.Name).ToList();

            ///<summary>
            /// Linq.Union()
            /// </summary>
            Student e = new Student("Mary", 5);
            List<Student> secondStudentList = new List<Student>() { e };
            List<Student> mergedStudentList = studentList.Union(secondStudentList).ToList();

            ///<summary>
            /// Linq.Intersect()
            /// </summary>
            List<Student> intersectedStudentList = studentList.Intersect(mergedStudentList).ToList();

            ///<summary>
            /// Linq subtract
            /// </summary>
            List<Student> subtractedStudentList = mergedStudentList.Except(studentList).ToList();
        }

        private static void FirstAssignment()
        {
            List<int> lista2 = new List<int> { 1, 2, 3, 4, 5, 6 };
            lista2.ShuffleListIList();

            int[] arrayList = new int[] { 1, 2, 3, 4, 5 };
            arrayList.ShuffleListIList();
        }
        private static void SecondAssignment()
        {
            List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6 };
            var test = lista.SnapFingers(n => n > 1);

            List<int> lista3 = new List<int> { 1, 2, 3 };
            var test2 = lista3.SnapFingers(n => n > 0);
        }
    }
}
