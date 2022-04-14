using System;
public delegate void del_example(string mess);//declaring delegate
class pro{
    public static void Main(string[]args){
        del_example del = new del_example(disp);//passing method name as parameter
        del("hello world");//calling method with parameter
    }
    public static void disp(string mess){
        Console.WriteLine(mess);
        Console.ReadLine();
    }
}