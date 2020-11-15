using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    class Footballist
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }
    class Team
    {
        Footballist[] footballists = new Footballist[11];

        public Footballist this[int index]
        {
            get { return footballists[index]; }
            set { footballists[index] = value; }
        }
    }
}
