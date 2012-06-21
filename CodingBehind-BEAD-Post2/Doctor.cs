using System;
using System.Diagnostics;

namespace CodingBehind_BED_Post2_EventHandler
{
    public class Doctor : PublicService
    {
        protected override void CheckService(object sender, CheckServicesArgs args)
        {
            args.ServicesWaiting.Add("Doctor");
        }

        protected override void GiveService(object sender, EventArgs args)
        {
            Debug.WriteLine("I am the DOCTOR");
        }
    }
}
