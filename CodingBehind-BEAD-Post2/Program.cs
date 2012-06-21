using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingBehind_BED_Post2_EventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();

            Fireman fireman = new Fireman();
            fireman.RegisterHouse(house);
            house.Check();

            Doctor doctor = new Doctor();
            doctor.RegisterHouse(house);
            house.Check();

            house.Burn();
        }
    }
}
