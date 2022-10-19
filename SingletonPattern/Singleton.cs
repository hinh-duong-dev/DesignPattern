using System;
namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton instance = null;

        private static readonly object lockObject = new object();

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;
        }

        public void Print()
        {
            Console.WriteLine($"Hello everyone, I am Singleton number {GetHashCode()}");
        }
    }
}
