using System;
namespace del_ex{
    public delegate void add(int a,int b);
    class example2{
        public static void Main(string[]args){
            add del = delegate(int a,int b){
                Console.WriteLine(a+b);
            };
            del(5,5);
            Console.ReadLine();      
        }
    }
}