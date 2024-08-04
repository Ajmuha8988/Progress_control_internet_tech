using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorAha
{
    class Result
    {
        public int ID_R { get; set; }
        private string Rank;
        public string rank
        {
            get { return Rank; }
            set { Rank = value; }
        }

        public Result() { }
        public Result(string Rank)
        {
            this.Rank = Rank;
        }


        public override string ToString()
        {
            return Rank;
        }
    }
}
