using System;
namespace program{
    class data
    {
        int a=10,b=0;
        public void sum(){
            try
            {
                a=a/b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("exception caugth:{0}",e);
            }
            finally{
                Console.WriteLine("Result=0");
            }
        }
    }
      class first{
        public static void Main(string[]args){
            data obj=new data();
            obj.sum();
            Console.ReadLine();
        }
    }
}