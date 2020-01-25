namespace BootCamp.Chapter.Examples
{
    class PassByRef_StringNotArray
    {
        public static void mm()
        {
            ChangeLetter1("C#Inm", 'n', 4);
            ChangeLetter2("C#Inm", 'n', 4);
            ChangeLetter3("C#Inm".ToCharArray(), 'n', 4);
        }

        public static void ChangeLetter1(string word, char letter, int index)
        {
            //word[index] = letter;
        }

        public static void ChangeLetter2(string word, char letter, int index)
        {
            word = word + letter;
        }

        public static void ChangeLetter3(char[] letterArray, char letter, int index)
        {
            letterArray[0] = letter;
        }
    }
}