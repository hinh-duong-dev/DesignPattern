using System;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Task.Run(() => Singleton.GetInstance().Print());
            Task.Run(() => Singleton.GetInstance().Print());

            Console.ReadLine();
        }
    }
}
