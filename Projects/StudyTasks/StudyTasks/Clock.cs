using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    class Clock
    {
        public int Hours { get; set; }

        public static implicit operator Clock(int a)
        {
            return new Clock { Hours = a % 24 };
        }
        public static explicit operator int(Clock clock)
        {
            return clock.Hours;
        }
    }
}
