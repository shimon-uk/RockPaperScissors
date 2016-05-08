using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissors
{
    public class Player : RockPaperScissors.IPlayer
    {
        public virtual PlayerType Type { get; set; }

        public virtual GameOptions Descision { get; set; }
    }
}
