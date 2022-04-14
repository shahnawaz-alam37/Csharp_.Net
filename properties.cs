using System;
namespace properties{
    class demo{
        int pin;
        public int Pin{//name of property is same as data,but in uppercase
            get{
                return pin;
            }
            set{
                pin=value;//value is a keyword
            }
        }
    }
    class program{
        public static void Main(string[]args){
            demo ob = new demo();
            ob.Pin=37;//passing value directly
            Console.WriteLine("Pin=" + ob.Pin);
            Console.ReadLine();
        }
    }
}