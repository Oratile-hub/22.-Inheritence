using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Chef chef1 = new Chef();
            Chef chef2 = new Chef();

            ItalianChef chef3 = new ItalianChef(); //object from Italian chef class

            Console.WriteLine("This now from the normal class chef");
            chef1.MakeChicken();
            chef2.MakeSalad(); //object based on normal chef class

          

            Console.WriteLine("This is now from the Italian chef");
            
            chef3.MakeChicken();
            chef3.MakeSalad();
            chef3.MakePasta();




            //freeze console
            Console.Read();
        }
    }
}
