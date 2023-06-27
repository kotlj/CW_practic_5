using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_practic_5
{
    class Bicycle
    {
        private int wheelsMuch;
        private string firm;
        private bool isWork;
        private static int totalProducted;

        public Bicycle(int _wheelsMuch, string _firm, bool _isWork)
        {
            wheelsMuch = _wheelsMuch;
            firm = _firm;
            isWork = _isWork;
            totalProducted++;
        }

        static Bicycle()
        {
            totalProducted = 0;
        }

        public void ride()
        {
            if (isWork)
            {
                Console.WriteLine("WeHe-e-e!");
            }
            else
            {
                Console.WriteLine("Need repair");
            }
        }
        static public int getProducted()
        {
            return totalProducted;
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Bicycle test = new Bicycle(2, "Someone", true);
            Console.WriteLine(Bicycle.getProducted());
        }
    }
}
