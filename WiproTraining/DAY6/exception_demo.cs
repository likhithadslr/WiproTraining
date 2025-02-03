//using System;

//namespace WiproTraining.DAY6
//{
//    internal class exception_demo
//    {
//        static void Main()
//        {
//            try
//            {
//                Console.WriteLine("Enter first number :");
//                int num1 = int.Parse(Console.ReadLine());

//                Console.WriteLine("Enter second number :");
//                int num2 = int.Parse(Console.ReadLine());

//                Console.WriteLine("Inside try block");

//                double result = num1 / num2;

//            }
//            finally
//            {
//                Console.WriteLine("Inside finally block");
//                // code will always execute, even if an exception is thrown
//            }

//            Console.WriteLine("End of main");

//        }
//    }
//}





//using System;
//public class InvalidAgeException : Exception
//{
//    public InvalidAgeException(String message) : base(message)
//    {
//    }
//}
//public class TestUserDefinedException
//{
//    static void validate(int age)
//    {
//        if (age < 18)
//        {
//            throw new InvalidAgeException("Sorry age must be >18 ");
//        }
//    }
//    public static void Main(string[] args)
//    {
//        try
//        {
//            validate(12);
//        }
//        catch (InvalidAgeException e)
//        {
//            Console.WriteLine(e);
//        }
//        Console.WriteLine("Rest of code here");
//    }
//}


