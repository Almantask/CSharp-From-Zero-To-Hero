using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Hints;

namespace BootCamp.Chapter
{
    class Teacher<TSubject>: ITeacher<TSubject> where TSubject : Subject,new()
    {
       public TSubject ProduceMaterial()
       {
            var like = new TSubject();
            return like;
        }
        public string Name
        {
            get
            {
                string s = typeof(TSubject).ToString(); ;
                var index = s.LastIndexOf(".");
                return s.Substring(index + 1);
            }
        }
        
    }
}
