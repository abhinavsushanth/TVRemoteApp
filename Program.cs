using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle ford = new Vehicle("Ford", 4, 80);
            
            if (ford is IDrivable)
            {
                ford.Move();
                ford.Stop();
            } else
            {
                Console.WriteLine($"The {ford.Brand} cannot be driven");
            }

            // Pick up Remote
            IElectronicDevice TV = TVRemote.GetDevice();

            // Next create power button
            PowerButton powerButton = new PowerButton(TV);

            // Turn TV On and Off
            powerButton.Execute();

            TV.VolumeUp();
            TV.VolumeUp();
            TV.VolumeUp();
            TV.VolumeUp();
            TV.VolumeDown();
            TV.VolumeDown();

            powerButton.Undo();

            Console.ReadLine();
        }
    }
}
