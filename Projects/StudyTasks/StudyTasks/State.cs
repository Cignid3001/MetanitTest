using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    class State
    {
        public decimal Population { get; set; }
        public decimal Area { get; set; }

        public static State operator +(State first, State second)
        {
            return new State
            {
                Population = first.Population + second.Population,
                Area = first.Area + second.Area
            };
        }

        public static bool operator >(State first, State second)
        {
            return first.Population > second.Population;
        }

        public static bool operator <(State first, State second)
        {
            return first.Population < second.Population;
        }
    }

}
