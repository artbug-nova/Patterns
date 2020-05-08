using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.GetInstance().GetHashCode());
            Console.WriteLine(Singleton.GetInstance().GetHashCode());
            Console.ReadKey();
        }
    }


    class Singleton
    {
        private static Singleton singleClass;


        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (singleClass == null)
                singleClass = new Singleton { };
            return singleClass;
        }
    }
}
