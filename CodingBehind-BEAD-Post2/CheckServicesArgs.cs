using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingBehind_BED_Post2_EventHandler
{
    public class CheckServicesArgs : EventArgs
    {
        public List<string> ServicesWaiting;

        public CheckServicesArgs() 
        { 
            ServicesWaiting = new List<string>(); 
        }
    }
}
