using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WiproTraining.DAY13_design_pattern.Program;

namespace WiproTraining.DAY13_design_pattern
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Singleton user1 = Singleton.GetInstance();
            user1.display("Data fetched by user 1");

            Singleton user2 = Singleton.GetInstance();
            user1.display("Data fetched by user 2");
        }
    
    }
        
    }

