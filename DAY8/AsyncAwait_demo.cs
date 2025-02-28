//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace WiproTraining.DAY8
//{
//    internal class AsyncAwait_demo
//    {
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                Method1();
//                Method2();
//                Console.ReadKey();
//            }
//            public static async Task Method1()
//            {
//                await Task.Run(() =>
//                {
//                    for (int i = 0; i < 10; i++)
//                    {
//                        Console.WriteLine("Method1");
//                    }
//                });
//            }
//            public static void Method2()
//            {
//                for (int i = 0; i < 25; i++)
//                {
//                    Console.WriteLine("Method2");

//                }
//            }
//        }
//    }
//}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace WiproTraining.DAY8
//{
//    internal class AsyncAwait_demo
//    {
//        class Program
//        {
//            static void Main(string[] args)
//            {

//                callMethod();
//            }
//            public static async void callMethod()
//            {
//                Task<int> task = Method1();
//                Method2();
//                int count = await task;
//                Method3(count);
//            }
//            public static async Task<int> Method1()
//            {
//                int count = 0;
//                await Task.Run(() =>
//                {
//                    for (int i = 0; i < 10; i++)
//                    {
//                        Console.WriteLine("Method1");
//                        count += 1;
//                    }
//                });
//                return count;
//            }
//            public static void Method2()
//            {
//                for (int i = 0; i < 25; i++)
//                {
//                    Console.WriteLine("Method2");

//                }
//            }

//        }
//    }
//}








