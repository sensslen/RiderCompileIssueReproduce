using ManagedCpp;
using NSubstitute;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_DelegatesToAdderAndReturnsSum()
        {
            var adder = Substitute.For<IInterface>();
            adder.Add(2, 3).Returns(5);
            var sut = new Intermediate.Math(adder);

            var result = sut.Add(2, 3);

            Assert.Equal(5, result);
            adder.Received(1).Add(2, 3);
        }
    }
}
