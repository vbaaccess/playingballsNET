using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPlayingBalls
{
    class ScoreData
    {
        public string NickName { get; set; }
        public int Score { get; set; }
        public DateTime ScoreDate { get; set; }

        public bool   SuscribNewGame { get; set; }
        public string SuscribEmail { get; set; }
    }
}
