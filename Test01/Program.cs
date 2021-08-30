using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();

            car.Motor = new MotorEngine();

            bool isCarStarted = car.Start();

            if (isCarStarted)
            {
                Console.WriteLine("Машина заведена");
            }
            else
            {
                Console.WriteLine("Машина не смогла завестись");
            }

            Console.ReadLine();

        }
    }

    public class Car
    {
        public MotorEngine Motor { get; set; }

        public bool Start()
        {
            if (Motor is null)
            {
                return false;
            }

            if (Motor.IsWorking)
            {
                return true;
            }

            return Motor.TurnOn();

        }
    }

    public class MotorEngine
    {
        private bool _isWorking;

        public bool IsWorking
        {
            get { return _isWorking; }
        }

        public bool TurnOn()
        {
            _isWorking = true;

            return _isWorking;
        }                     Unit тесты будут?

        public bool TurnOff()
        {
            _isWorking = false;

            return _isWorking;
        }
    }

}
