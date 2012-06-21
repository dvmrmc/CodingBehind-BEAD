using System.Diagnostics;
namespace EventsDelegateTest
{
    public class House
    {
        //Delegate declaration
        public delegate void FireAlarmDelegate();

        //FireAlarm event declaration
        public static event FireAlarmDelegate FireAlarm;
        private static void RaiseFireAlarm()
        {
            if (FireAlarm != null)
                FireAlarm();
        }

        public static void Burn()
        {
            Debug.WriteLine("Burn!!");

            RaiseFireAlarm();
        }
    }
}
