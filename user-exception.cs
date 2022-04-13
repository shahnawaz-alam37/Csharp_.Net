using System;
public class invalidageException : Exception
{
    public invalidageException(string message)
    :base(message) 
    { 
    }
}
public class test{
    public void validate(int age){
        if (age<18){
            throw new invalidageException("sorry,age must be greater than 18");
        }
    }

    public static void Main(string[]args){
        test obj=new test();
        try
        {
            obj.validate(12);
        }
        catch (invalidageException e)
        {
            Console.WriteLine(e);
        }
    }
}