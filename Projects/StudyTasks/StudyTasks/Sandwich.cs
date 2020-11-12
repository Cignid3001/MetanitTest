using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    class Bread
    {
        public int Weight { get; set; }
    }

    class Butter
    {
        public int Weight { get; set; }
    }

    class Sandwich
    {
        public int Weight { get; set; }

        public static Sandwich operator +(Bread bread, Butter butter)
        {
            return new Sandwich
            {
                Weight = butter.Weight + bread.Weight
            };
        }
    }
}
