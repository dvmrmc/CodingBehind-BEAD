using System.Diagnostics;
using System;

namespace CodingBehind_BED_Post2_EventHandler
{
    public class Fireman : PublicService
    {
        protected override void CheckService(object sender, EventFireAlarm args)
        {
            args.ServicesWaiting.Add("Fireman");
        }

        protected override void GiveService(object sender, EventArgs args)
        {
            Debug.WriteLine("I am the FIREMAN");
        }
    }
}
