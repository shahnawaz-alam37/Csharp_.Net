using System;
namespace del_ex{
    public delegate void adddel(int a,int b);
    class example{
        public void addnums(int a,int b){
            Console.WriteLine(a+b);
        }
        public static void Main(string[]args){
            example ob = new example();
            adddel del = new adddel(ob.addnums);
            del(5,5);
            Console.ReadLine();      
        }
    }
}