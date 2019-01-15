using System;

namespace _08.Personal_Exception
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                try
                {
                    if (num >= 0)
                        Console.WriteLine(num);
                    else
                        throw new MyException();
                }
                catch (MyException myEx)
                {
                    Console.WriteLine(myEx.Message);
                    break;
                }
            }
        }
    }

    public class MyException : Exception
    {
        public MyException()
        {
            this.Message = "My first exception is awesome!!!";
        }

        public override string Message { get; }
    }
}
