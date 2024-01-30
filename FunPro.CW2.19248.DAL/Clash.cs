using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunPro.CW2._19248.DAL
{
    internal class Clash
    {
        public int Id { get; set; }
        public int Player1 { get; set; }
        public int Player2 { get; set; }
        public DateTime Date { get; set; }
        public int Outcome { get; set; }

        public Clash(int cl_player1, int cl_player2, DateTime cl_date, int cl_outcome)
        {
            Player1 = cl_player1;
            Player2 = cl_player2;
            Date = cl_date;
            Outcome = cl_outcome;
        }
    }
}
