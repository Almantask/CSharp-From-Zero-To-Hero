using System;
using System.Text;

namespace BootCamp.Chapter
{
    class CaesarCipher
    {
        public static void Demo()
        {
            bool isContinue = true;
            while (isContinue)
            {
                int shift = UserSelectSizeAndDirectionOfShift();
                string forOperation = RequestInput();
                ConvertString(shift, forOperation);
                isContinue = UserSelectsContinue();
            }
        }
      
            private static bool UserSelectsContinue()
        {
            Console.WriteLine("Please enter \"c\" to continue, any other key to exit");
            string response = Console.ReadLine();
            return ((response == "c") || (response == "C"));
         }

        private static int UserSelectSizeAndDirectionOfShift()
        {
            Console.WriteLine("Please indicate how many letters your cipher shifts (the key). This should be a range from -25 (the the left) to 25 (to the right)");
            
            try
            {
                int shift = int.Parse(Console.ReadLine());
                if (Math.Abs(shift) > 25)
                {
                    Console.WriteLine($"Your cipher key, {shift} is greater than 25 and will cycle completely through the alphabet and result in a shift of {shift % 26}.");
                    return (shift % 26);
                }
                return shift;
            }
            catch (Exception e)
            {
                Console.WriteLine("That is not a valid input.");
                return UserSelectSizeAndDirectionOfShift();
            }
            
        }

        private static string RequestInput()
        {
            Console.WriteLine("Please input text for the caesar cipher");

            try
            {
               return Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("That is not a valid text for the caesar cipher program you got FREE OF CHARGE.");

                return RequestInput();
            }
        }
        private static void ConvertString(int shift, string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var letter in input)
            {
                char d = char.IsUpper(letter) ? 'A' : 'a';
                if (char.IsLetter(letter))
                {
                    char newChar = (int)letter + shift < (int)d ? (char)((int)letter + shift + 26) : (char)((((letter + shift) - d) % 26) + d);
                    sb.Append(newChar);
                }
                else
                {
                    sb.Append(letter);
                }
            }
            Console.WriteLine($"A key of {shift} results in this text: {sb.ToString()}");
        }
    
    }
}
