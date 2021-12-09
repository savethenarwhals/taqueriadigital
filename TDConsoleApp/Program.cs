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

    class TacoOrder
    {
        readonly private string _customerName;
        readonly private TacoFilling _filling;
        readonly private TacoSide _side;
        readonly private TacoSalsa _salsa;

        // Constructor method
        public TacoOrder(string customerName, TacoFilling filling, TacoSide side, TacoSalsa salsa)
        {
            _customerName = customerName;
            _filling = filling;
            _side = side;
            _salsa = salsa;
        }

        // Getters
        // Methods to return instance variables

        // Get _customerName
        // Get _filling
        // Get _side
        // Get _salsa




        // Setters
        // Methods to set instance variables
        // Set _customerName
        // Get _filling
        // Get _side
        // Get _salsa




        public string displayTacoOrder()
        {
            return ($"Customer Name: {_customerName}\nTaco Filling: {_filling}\nTaco Side: {_side}\nTaco Salsa: {_salsa}");
        }


    }

    // Add accessibility modifiers to enums.

    enum TacoFilling
    {
        CarneAsada,
        Carnitas,
        AlPastor,
        GrilledChicken
    }

    enum TacoSide
    {
        Rice,
        BlackBeans,
        PintoBeans,
        BorrachoBeans
    }

    enum TacoSalsa
    {
        PicoDeGallo,
        SalsaRoja,
        SalsaVerde
    }
}
