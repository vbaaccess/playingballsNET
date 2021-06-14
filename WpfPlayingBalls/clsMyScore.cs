using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPlayingBalls
{
    class clsMyScore
    {

        public int myPlaceInTheRanking { get; set; }
        public string myNickName { get; set; }
        public int myScore { get; set; }
        public DateTime myScoreDate { get; set; }

        private clsMyScore() { }

        //public clsMyScore(string NickName, int NewScore)
        //{
        //    this.myPlaceInTheRanking = 1;
        //    this.myScoreDate = DateTime.Now;
        //    this.myNickName = NickName;
        //    this.myScore = NewScore;

        //}

        public clsMyScore(int Place, string NickName, int NewScore, DateTime ScoreDate)
        {
            this.myPlaceInTheRanking = Place;
            this.myScoreDate = ScoreDate;
            this.myNickName = NickName;
            this.myScore = NewScore;

        }
    }
}
