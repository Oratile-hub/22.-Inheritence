using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Inheritence
{
    internal class ItalianChef : Chef //Italian chef inherits from chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Make Pasta");
        }

        public void MakeSalad()
        {
            Console.WriteLine("This chef makes Italian salad");
        }

    }
}
