using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cat> catArmy = new List<Cat>();
         
             List <Turtles> turtlArmy = new List<Turtles>();

            Random rand = new Random();


            //Lets create our aremys

            for (int i = 0; i < 100; i++)
            {
                if(rand.NextDouble() >= 0.5)
                {
                    catArmy.Add(new Cat());
                }
                else
                {
                    turtlArmy.Add(new Turtles());
                }
            }
        
        }
    }
}
