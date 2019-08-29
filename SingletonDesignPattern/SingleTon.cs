using System;

namespace SingletonDesignPattern
{
    public sealed class Singleton
    {
        public static int ctr = 0; 
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        /// <summary>
        /// Public Property
        /// </summary>
        public static Singleton GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        /// <summary>
        /// Private Construstor 
        /// </summary>
        private Singleton()
        {
            ctr++;
            Console.WriteLine(ctr);
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine("Print Details " + message);
        }
    }
}
