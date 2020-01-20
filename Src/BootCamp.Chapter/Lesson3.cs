using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            bool moreUserEntries = true;

            while (moreUserEntries)
            {
                PersonInfo.UserInfo();
                moreUserEntries = AddAnotherUser.AddAnotherPerson();
            }
        }
    }
}
