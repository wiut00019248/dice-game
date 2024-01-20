using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunPro.CW2._19248
{
    internal class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPvpEnabled { get; set; }
        public DateTime LastGameDate { get; set; }
        public int Score { get; set; }

        public Player(string pl_name, bool pl_is_pvp_enabled, DateTime pl_last_game_date, int pl_score)
        {
            Name = pl_name;
            IsPvpEnabled = pl_is_pvp_enabled;
            LastGameDate = pl_last_game_date;
            Score = pl_score;
        }
    }
}
