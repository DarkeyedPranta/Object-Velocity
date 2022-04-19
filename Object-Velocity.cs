using System;
using System.Threading;

namespace Problem_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sec = 6;
            double GravityAccelaration = 9.81;
            double Speed = (GravityAccelaration * Sec);
            double Distance = (0.5 * GravityAccelaration * Sec * Sec);
            Console.WriteLine($"After time interval of 6 seconds the speed of the object will be {Speed:F2} m/sec.");
            Console.WriteLine($"After time interval of 6 seconds the distance travelled will be {Distance:F2} metres.");
        }
    }
}

