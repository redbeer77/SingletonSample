using SingletonSample.Sample;
using System;

namespace SingletonSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Init");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(Singleton.IncrementCounter());
            }

            //in constructor use Singleton
            OtherClass oc = new OtherClass();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(Singleton.IncrementCounter());
            }
            Console.WriteLine("Main End!");
            //stop console to see 
            Console.ReadKey();
        }
    }
}
