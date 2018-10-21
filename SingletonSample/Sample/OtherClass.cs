using System;

namespace SingletonSample.Sample
{
    public class OtherClass
    {

        public OtherClass()
        {

            Console.WriteLine("OtherClass Init");

            for (int i = 0; i < 5; i++)
            {
                //Calling Singleton
                Console.WriteLine(Singleton.IncrementCounter());           
            }

            Console.WriteLine("Other Class End");
        }
    }
}
