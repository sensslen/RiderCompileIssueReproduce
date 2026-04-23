using ManagedCpp;

namespace Intermediate
{
    public class Math
    {
        private readonly IInterface _adder;

        public Math(IInterface adder)
        {
            _adder = adder;
        }

        public int Add(int a, int b)
        {
            return _adder.Add(a, b);
        }
    }
}
