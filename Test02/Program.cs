using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class MotorEngine
    {

    }

    public class Car
    {
        /// <summary>
        /// Локальное поле, которое видно только внутри класса
        /// и установить значения можно только через конструктор класса,
        /// т. к. стоит ключевое слово readonly
        /// </summary>
        private readonly string _markName;
        /// <summary>
        /// Локальное поле, которое видно только внутри класса
        /// и его значение может меняться извне либо внутри класса,
        /// т. к. не стоит ключевое слово readonly
        /// </summary>
        private MotorEngine _motor;

        /// <summary>
        /// Конструктор по умолчанию.
        /// В качестве марки машины устанавливается значение "Unknown Mark"
        /// посредством вызова другого конструктора
        /// public Car(string markName)
        /// </summary>
        public Car()
            : this("Unknown Mark")
        {

        }

        /// <summary>
        /// Конструктор с принудительным присвоением марки машины
        /// </summary>
        /// <param name="markName">Марка машины</param>
        public Car(string markName)
        {
            _markName = markName;
        }

        /// <summary>
        /// Конструктор, через который устанавливаются все поля —
        /// от марки машины до мотора.
        /// </summary>
        /// <param name="markName"></param>
        /// <param name="engine"></param>
        public Car(string markName, MotorEngine engine)
        {
            _markName = markName;
            _motor = engine;
        }

        /// <summary>
        /// Публичное свойство только на чтение.
        /// Ни один потребитель извне не сможет его поменять,
        /// т. к. здесь отсутствует set
        /// </summary>
        public string MarkName => _markName;

        /// <summary>
        /// Публичное свойство, которое может быть изменено извне,
        /// т. к. здесь есть set
        /// </summary>
        public MotorEngine Motor
        {
            get => _motor;
            set => _motor = value;
        }

        /// <summary>
        /// Публичный метод, который доступен извне класса потребителю.
        /// Т. е. его можно вызвать у объекта
        /// </summary>
        /// <returns>Значение</returns>
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


}
