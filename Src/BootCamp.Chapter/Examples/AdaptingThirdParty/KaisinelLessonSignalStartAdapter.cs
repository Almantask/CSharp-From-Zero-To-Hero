using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Examples.AdaptingThirdParty._3rdParty;
using BootCamp.Chapter.Examples.InterfacePolution.Good;
using KaisinelBootCampService = BootCamp.Chapter.Examples.AdaptingThirdParty._3rdParty.KaisinelBootCampService;
using Lesson = BootCamp.Chapter.Examples.InterfacePolution.Good.Lesson;

namespace BootCamp.Chapter.Examples.AdaptingThirdParty
{
    public class KaisinelLessonSignalStartAdapter : ILessonNotifier
    {
        private readonly IBootCampService _bootCampService;

        public KaisinelLessonSignalStartAdapter(KaisinelBootCampService kaisinelBootCampService)
        {
            _bootCampService = kaisinelBootCampService;
        }

        public void SignalStart(Lesson lesson) => _bootCampService.SignalStart(new _3rdParty.Lesson());
    }

    public class KaisinelLessonStreamAdapter : ILessonStreamer
    {
        private readonly IBootCampService _bootCampService;

        public KaisinelLessonStreamAdapter(KaisinelBootCampService kaisinelBootCampService)
        {
            _bootCampService = kaisinelBootCampService;
        }


        public void Stream(Lesson lesson) => _bootCampService.Stream(new _3rdParty.Lesson());
    }
}
