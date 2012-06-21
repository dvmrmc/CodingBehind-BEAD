using System.Diagnostics;
namespace EventsDelegateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Fireman fireman = new Fireman();
            Doctor doctor = new Doctor();

            House.Burn();
        }
    }
}
