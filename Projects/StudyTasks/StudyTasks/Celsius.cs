using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    class Celcius
    {
        public double Gradus { get; set; }

        public static implicit operator Fahrenheit(Celcius celcius)
        {
            return new Fahrenheit { Gradus = 9.0 / 5 * celcius.Gradus + 32 };
        }
        public static explicit operator Celcius(Fahrenheit fahrenheit)
        {
            return new Celcius { Gradus = 5.0 / 9 * (fahrenheit.Gradus - 32) };
        }
    }
    class Fahrenheit
    {
        public double Gradus { get; set; }
    }
}
