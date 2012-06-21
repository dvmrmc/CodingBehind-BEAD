using System.Diagnostics;
using System;
using System.Collections.Generic;

namespace CodingBehind_BED_Post2_EventHandler
{
    public class House : PublicServiceConsumer
    {
        public void Check()
        {
            Debug.WriteLine("==============");
            Debug.WriteLine("Check Services");
            Debug.WriteLine("------------------------");

            foreach (string service in RaiseCheckServices())
            {
                Debug.WriteLine("- " + service);
            }

            Debug.WriteLine("==============");
        }

        public void Burn()
        {
            Debug.WriteLine("==============");
            Debug.WriteLine("Raise Fire alarm");
            Debug.WriteLine("==============");
            RaiseFireAlarm();
            Debug.WriteLine("==============");
        }
    }
}
