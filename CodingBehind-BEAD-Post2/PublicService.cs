using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingBehind_BED_Post2_EventHandler
{
    public class PublicService
    {
        public void RegisterHouse(House house)
        {
            house.CheckServices += CheckService;
            house.FireAlarm += GiveService;
        }

        protected virtual void CheckService(object sender, CheckServicesArgs args)
        {
            //Do nothing, expected to be implemented in a concrete service
        }

        protected virtual void GiveService(object sender, EventArgs args)
        {
            //Do nothing, expected to be implemented in a concrete service
        }
    }
}
