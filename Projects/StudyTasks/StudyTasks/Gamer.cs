using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    class Gamer
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }
    class Command
    {
        Gamer[] gamers = new Gamer[11];

        public Gamer this[int index]
        {
            get
            {
                if (index >= 0 && index <= gamers.Length)
                    return gamers[index];
                else
                    return null;
            }
            set
            {
                if (index >= 0 && index < gamers.Length)
                    gamers[index] = value;
            }
        }
    }
}
