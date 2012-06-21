using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingBehind_BED_Post2_EventHandler
{
    public class EventFireAlarm : EventArgs
    {
        public List<string> ServicesWaiting;

        public EventFireAlarm() 
        { 
            ServicesWaiting = new List<string>(); 
        }
    }
}
