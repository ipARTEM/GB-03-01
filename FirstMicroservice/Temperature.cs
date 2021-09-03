using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMicroservice
{
    public class Temperature
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public void CopyData(Temperature temperature)
        {
            Date = temperature.Date;
            TemperatureC = temperature.TemperatureC;
            Summary = temperature.Summary;
        }

        public override bool Equals(object obj) =>
            obj is Temperature temperature ? this == temperature : false;

        public override int GetHashCode() =>
            ~Date.GetHashCode() * TemperatureC.GetHashCode();

        public static bool operator ==(Temperature t1, Temperature t2)
        {
            if (ReferenceEquals(t1, null) || ReferenceEquals(t2, null))
                return false;
            return t1.Date == t2.Date &&
                t1.TemperatureC == t2.TemperatureC &&
                t1.Summary == t2.Summary;

        }

        public static bool operator !=(Temperature t1, Temperature t2) =>
            !(t1 == t2);


    }
}
