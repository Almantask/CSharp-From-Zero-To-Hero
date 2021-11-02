using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Demo
    {
        public static void PartOne()
        {
            var logger = new Logger();
            logger.Log("Start of program");

            try
            {
                string[] arrayS = new string[5];

                int[] arrayInt = new int[5];

                for (int i = 0; i < arrayInt.Length; i++)
                {
                    arrayInt[i] = i;
                }

                foreach (var item in arrayInt)
                {
                    logger.Log(item.ToString());
                }

                foreach (var test in arrayS)
                {
                    Console.WriteLine(test);
                }

                updateArray(arrayS);

                foreach (var test in arrayS)
                {
                    logger.Log($"{test}");
                }

                ///<summary>
                /// checking logging of error messages
                ///</summary>
                arrayInt[6] = 2;

                Console.ReadKey();
                logger.Log("End of program");
            }
            catch (Exception ex)
            {
                string error = ("Program fail, reason: \n" + ex.ToString());
                logger.Log(error);
            }
        }

        public static void updateArray(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = "test " + i;
            }
        }
    }
}
