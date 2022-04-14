using System;
namespace overload{
    class program{
        public void add(int a,int b){
            Console.WriteLine(a+b);
        }
        public void add(double a,double b){
            Console.WriteLine(a+b);
        }
        public static void Main(string[]args){
            program ob=new program();
            ob.add(1,1);
            ob.add(1.1,1.1);
            Console.ReadLine();
        }
    }
}