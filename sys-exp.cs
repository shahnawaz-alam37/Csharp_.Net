using System;

namespace err
{
  class abc
  {
    public static void main(string[] args)
    {
      try
      {
        int[] a = {1, 2, 3};
        Console.WriteLine(a[10]);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }    
    }
  }
}