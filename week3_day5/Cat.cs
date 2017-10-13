using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day5
{
    class Cat
    {

        private int CatCount
        {
            get { return this.CatCount; }
            set { this.CatCount = value; }
        }

        public Cat()
        {

        }

        public void Warcry()
        {
            Console.WriteLine("week3_day5 are a army of " + CatCount);
        }
    }
}
