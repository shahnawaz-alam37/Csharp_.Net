using System;
using System.Threading;
namespace threadExample
{
    class program
    {
        public static void Main(string[]args){
            Thread t1 = new Thread(new ThreadStart(printnum));
            t1.Start();
            Console.WriteLine("main thread completed");
            Console.ReadLine();
        }
        static void printnum(){
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i="+i);
            }
            Console.WriteLine("completion of user defined thread");
        }
    }
}