namespace TDConsoleApp
{
    class TacoOrder
    {
        private string _customerName;
        private TacoFilling _filling;
        private TacoSide _side;
        private TacoSalsa _salsa;
        private int _tacoQuantity;

        // Constructor method
        public TacoOrder(string customerName, TacoFilling filling, TacoSide side, TacoSalsa salsa, int tacoQuantity)
        {
            _customerName = customerName;
            _filling = filling;
            _side = side;
            _salsa = salsa;
            _tacoQuantity = tacoQuantity;

        }

        // Add properties


        // Getters
        // Methods to return instance variables

        public string GetCustomerName() => _customerName;
        public TacoFilling GetTacoFilling() => _filling;
        public TacoSide GetTacoSide() => _side;
        public TacoSalsa GetTacoSalsa() => _salsa;
        public int GetTacoQuantity() => _tacoQuantity;

        // Setters
        // Methods to set instance variables

        public void SetCustomerName(string value) => _customerName = value;
        public void SetTacoFilling(TacoFilling value) => _filling = value;
        public void SetTacoSide(TacoSide value) => _side = value;
        public void SetTacoSalsa(TacoSalsa value) => _salsa = value;
        public void SetTacoQuantity(int value) => _tacoQuantity = value;

        // Methods

    }
}
