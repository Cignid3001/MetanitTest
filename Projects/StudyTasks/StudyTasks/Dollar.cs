using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    class Dollar
    {
        public decimal Sum { get; set; }

        public static implicit operator Dollar(Euro euro)
        {
            return new Dollar { Sum = euro.Sum * 1.14M };
        }

        public static explicit operator Euro(Dollar dollar)
        {
            return new Euro { Sum = dollar.Sum / 1.14M};
        }
    }
    class Euro
    {
        public decimal Sum { get; set; }
    }
}
