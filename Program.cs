using System;


namespace  XayDungLopFan
{
    class Program
    {
        static void Main(string[]args)
        {
            Fan fan1 = new Fan(Fan.fast,true,10,"Yellow");
            Console.WriteLine(fan1.ToString());
            Fan fan2 = new Fan(Fan.medium,false,5,"Blue");
            Console.WriteLine(fan2.ToString());            
        }
    }
}