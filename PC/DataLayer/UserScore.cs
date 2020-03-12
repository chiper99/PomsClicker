using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC.DataLayer
{
    public class UserScore
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public int EvaCount { get; set; }

        public int EvaCost { get; set; }

        public int NewtonCount { get; set; }

        public int NewtonCost { get; set; }

        public int JobsCount { get; set; }

        public int JobsCost { get; set; }

        public int Score { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
