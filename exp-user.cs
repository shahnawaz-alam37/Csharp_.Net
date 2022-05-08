using System;
namespace err
{
  class demo
  {
    public void checkAge(int age)
    {
      if (age < 18)
      {
        throw new ArithmeticException("Access denied - You must be at least 18 years old.");
      }
      else
      {
        Console.WriteLine("Access granted - You are old enough!");
      }
    }
   static void main(string[] args)
    {
      demo ob= new demo();
      ob.checkAge(20);
    }
  }
}