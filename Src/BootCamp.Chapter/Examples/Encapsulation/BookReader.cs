using System.Security.Cryptography.X509Certificates;

namespace BootCamp.Chapter.Examples.Encapsulation
{
    public class MusicPlayer
    {
        public void Play()
        {
        }
        public void Pause()
        {
        }
        public void Next()
        {
        }
        public void Previous()
        {
        }

        public Song ReadSong(string name)
        {
            return null;
        }
        public void SaveLastSelection(Song song)
        {
        }
    }

    public class Song
    {
    }
}
