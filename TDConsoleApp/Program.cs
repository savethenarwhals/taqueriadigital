using System;

namespace TDConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TacoOrder tacoCustomer1 = new("Angelina Jolie", TacoFilling.CarneAsada, TacoSide.BlackBeans, TacoSalsa.SalsaRoja);
            Console.WriteLine(tacoCustomer1.displayTacoOrder());
        }        
    }
}
