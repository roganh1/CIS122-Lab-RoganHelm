using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    public class QuizStatistics
    {
        private double score = double.MinValue;
        private double score1 = double.MinValue;
        private double score2 = double.MinValue;
        private double score3 = double.MinValue;
        private double score4 = double.MinValue;
        public double Score { get { return score; } set { score = value; } }
        public double Score1 { get { return score1; } set { score1 = value; } }
        public double Score2 { get { return score2; } set { score2 = value; } }
        public double Score3 { get { return score3; } set { score3 = value; } }
        public double Score4 { get { return score4; } set { score4 = value; } }
        public double Average()
        {
            return (this.score + this.score1 + this.score2 + this.score3 + this.score4) / 5
        }
    }
}
