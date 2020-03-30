using System;

namespace BootCamp.Chapter
{
    internal class OnMonsterHitEventArgs : EventArgs
    {
        public OnMonsterHitEventArgs(int damageTaken)
        {
            DamageTaken = damageTaken;
        }

        public int DamageTaken { get; }
    }
}