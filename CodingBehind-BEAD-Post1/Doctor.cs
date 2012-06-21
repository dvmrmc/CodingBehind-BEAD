using System.Diagnostics;

namespace EventsDelegateTest
{
    public class Doctor
    {
        public Doctor()
        {
            // I am the DOCTOR and I want to be 
            // notified when the house is on fire.
            House.FireAlarm += HouseIsOnFire;
        }

        private void HouseIsOnFire()
        {
            Debug.WriteLine("I am the DOCTOR");
        }
    }
}
