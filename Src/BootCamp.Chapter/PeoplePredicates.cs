using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class PeoplePredicates
    {
        public static EventHandler OnPredicate;

        /// <summary>
        /// a) over 18, who do not live in UK, whose surename does not contain letter 'a'.
        /// </summary>
        /// <returns></returns>
        public static bool IsA(Person person) => RunPredicateEvent() && person.IsOver18 && !person.IsLivingInUK && !person.HasAInLastName;

        /// <summary>
        /// b) under 18,  who do not live in UK, whose surename does not contain letter 'a'.  
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static bool IsB(Person person) => RunPredicateEvent() && !person.IsOver18 && !person.IsLivingInUK && !person.HasAInLastName;

		/// <summary>
		/// c) who do not live in UK, whose surename and name does not contain letter 'a'.  
		/// </summary>
		/// <param name="person"></param>
		/// <returns></returns>
		public static bool IsC(Person person) => RunPredicateEvent() && !person.IsLivingInUK && !person.HasAInLastName && !person.HasAInName;

        private static bool RunPredicateEvent()
        {
            OnPredicate?.Invoke(null, new EventArgs());
            return true;
        }
	}
}
