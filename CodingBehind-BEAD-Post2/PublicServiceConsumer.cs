using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingBehind_BED_Post2_EventHandler
{
    public class PublicServiceConsumer
    {
        //CheckServices event declaration
        public event EventHandler<CheckServicesArgs> CheckServices;
        protected List<string> RaiseCheckServices()
        {
            CheckServicesArgs args = new CheckServicesArgs();

            if (CheckServices != null)
                CheckServices(this, args);

            return args.ServicesWaiting;
        }

        //FireAlarm event declaration
        public event EventHandler FireAlarm;
        protected void RaiseFireAlarm()
        {
            if (FireAlarm != null)
                FireAlarm(this, null);
        }
    }
}
