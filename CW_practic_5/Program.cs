using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_practic_5
{
    internal class Program
    {
        class Bicycle
        {
            private int wheelsMuch;
            private string firm;
            private bool isWork;
            public static int totalProducted;

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
        }
        static void Main(string[] args)
        {
            Bicycle test = new Bicycle(2, "Someone", true);
            Console.WriteLine(Bicycle.totalProducted);
        }
    }
}
