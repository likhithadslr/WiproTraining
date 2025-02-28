using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproTraining.DAY13_design_pattern
{
    internal class Program
    {
        public sealed class Singleton
        {
            public static int cntr = 0;
            private static Singleton Instance = null;
            public static Singleton GetInstance()
            {
                if (Instance == null)
                {
                    Instance = new Singleton();
                }
                return Instance;

            }
            private Singleton()
            {
                cntr++;
                Console.WriteLine("Counter value: " + cntr.ToString());

            }
            public void display(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}
