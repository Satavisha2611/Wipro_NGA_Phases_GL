using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
namespace DesignPattern
{
    /*public sealed class Singleton
   {
       private static int cntr = 0;

       private static Singleton Instance = null;

       public static Singleton GetInstance()
       {
           if (Instance == null)
           {
               Instance = new Singleton();
           }
           return Instance;

       }

       private Singleton()
       {
           cntr++;
           Console.WriteLine("Counter Value :" + cntr.ToString());

       }

       public void Display(string message)
       {


           Console.WriteLine(message);


       }


   }





       public class MainClass
       {
           public static void Main(string[] args)
           {
               //  Singleton s = new Singleton();

               Singleton user1 = Singleton.GetInstance();
               user1.Display("Data fetched by user 1");

               Singleton user2 = Singleton.GetInstance();
               user2.Display("Data fetched by user 2");

           }

       }*/


    public class MobileFactory
    {
        // public static MobileFactory _mobile;
        public static IMobile CreatInstance(string name)
        {
            return name.ToLower() switch
            {
                "android" => new Android(),
                "iphone" => new IPhone(),
                _ => throw new Exception()
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter name of a model mobile:");
             string name = Console.ReadLine();
             IMobile _mobile = MobileFactory.CreatInstance(name);
             _mobile.NewMobile();
            */

            AmericanCharger charger = new AmericanCharger();

            // we are making indian to use the american one with an indian socket
            IndianSocket adapter = new ChargerAdapter(charger);
            adapter.Charger();
        }
    }
}

