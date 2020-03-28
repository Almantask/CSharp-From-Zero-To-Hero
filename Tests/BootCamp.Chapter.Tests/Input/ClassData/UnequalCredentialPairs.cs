using System.Collections;
using System.Collections.Generic;

namespace BootCamp.Chapter.Tests.Input.ClassData
{
    public class UnequalCredentialPairs : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var credentials = GenerateCredentials();

            for (var index1 = 0; index1 < credentials.Count; index1++)
            {
                var credential1 = credentials[index1];
                for (var index2 = 1; index2 < credentials.Count; index2++)
                {
                    if (index1 == index2) continue;
                    var credential2 = credentials[index2];

                    yield return new object[] { credential1, credential2 };
                }
            }
        }

        private IList<Credentials> GenerateCredentials()
        {
            var usernames = new[] { "Tom", "Jack" };
            var passwords = new[] { "Tom123", "Jack123" };

            var credentials = new List<Credentials>();
            foreach (var username in usernames)
            {
                foreach (var password in passwords)
                {
                    credentials.Add(new Credentials(username, password));
                }
            }

            return credentials;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}