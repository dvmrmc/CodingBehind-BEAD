using System.Diagnostics;

namespace EventsDelegateTest
{
    public class Fireman
    {
        public Fireman()
        {
            // I am the FIREMAN and I want to be 
            // notified when the house is on fire.
            House.FireAlarm += HouseIsOnFire;
        }

        private void HouseIsOnFire()
        {
            Debug.WriteLine("I am the FIREMAN");
        }
    }
}
