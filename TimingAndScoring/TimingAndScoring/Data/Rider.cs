using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimingAndScoring.Data
{
    public class Rider
    {
        public int CurrentPlace { get; set; }
        public int Number { get; set; }
        public string LastName { get; set; }
        public string SecondsDown { get; set; }
        public int LapsDown { get; set; }
        public double LastLapTime { get; set; }
        public int SeasonPoints { get; set; }
        public int SeasonPosition { get; set; }
    }
}
