using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorAha
{
    class Save
    {
        public int ID { get; set; }
        private string Fullname;
        private string Result;

        public string fullname
        {
            get { return Fullname; }
            set { Fullname = value; }
        }

        public string result
        {
            get { return Result; }
            set { Result = value; }
        }

        public Save() { }
        public Save(string Fullname, string Result)
        {
            this.Fullname = Fullname;
            this.Result = Result;
        }

        public override string ToString()
        {
            return Fullname + Result;
        }
    }
}
