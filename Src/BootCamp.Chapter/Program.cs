using System;
using v1 = BootCamp.Chapter.V1;
using v2 = BootCamp.Chapter.V2;

namespace BootCamp.Chapter
{
    class Program
    {
        public static void Main()
        {
            TestV1();
            TestV2();
        }

        private static void TestV1()
        {
            Console.WriteLine("---- V1 test------");

            var human = new v1.Human();
            var robot = new v1.Robot();
            var dogRobot = new v1.DogRobot();

            human.Talk();
            human.Walk();

            robot.Talk();
            robot.Walk();

            dogRobot.Talk();
            dogRobot.Walk();
        }

        private static void TestV2()
        {
            Console.WriteLine("---- V2 test------");

            var human = new v2.Human();
            var robot = new v2.Robot();
            var dogRobot = new v2.DogRobot();

            human.Talk();
            human.Walk();

            robot.Talk();
            robot.Walk();

            dogRobot.Talk();
            dogRobot.Walk();

            dogRobot.Bite();
            dogRobot.EmergencyShutdown();
        }
    }

}
