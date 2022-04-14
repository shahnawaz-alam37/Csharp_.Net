using System;
public delegate void del_example(string mess);
class pro{
    public static void Main(string[]args){
        del_example del = new del_example(disp);
        del("hello world");
    }
    public static void disp(string mess){
        Console.WriteLine(mess);
        Console.ReadLine();
    }
}