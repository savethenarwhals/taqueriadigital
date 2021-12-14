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
        private string _customerName;
        private TacoFilling _filling;
        private TacoSide _side;
        private TacoSalsa _salsa;

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

        public string GetCustomerName() => _customerName;
        public TacoFilling GetTacoFilling() => _filling;
        public TacoSide GetTacoSide() => _side;
        public TacoSalsa GetTacoSalsa() => _salsa;

        // Setters
        // Methods to set instance variables

        public void SetCustomerName(string value) => _customerName = value;
        public void SetTacoFilling(TacoFilling value) => _filling = value;
        public void SetTacoSide(TacoSide value) => _side = value;
        public void SetTacoSalsa(TacoSalsa value) => _salsa = value;



        public string displayTacoOrder()
        {
            return ($"Customer Name: {_customerName}\nTaco Filling: {_filling}\nTaco Side: {_side}\nTaco Salsa: {_salsa}");
        }


    }

    public enum TacoFilling
    {
        CarneAsada,
        Carnitas,
        AlPastor,
        GrilledChicken
    }

    public enum TacoSide
    {
        Rice,
        BlackBeans,
        PintoBeans,
        BorrachoBeans
    }

    public enum TacoSalsa
    {
        PicoDeGallo,
        SalsaRoja,
        SalsaVerde
    }
}
