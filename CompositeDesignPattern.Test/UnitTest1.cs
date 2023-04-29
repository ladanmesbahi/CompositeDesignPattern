using CompositeDesignPattern.Implementations;

namespace CompositeDesignPattern.Test
{
    public class CompositeDesignPatternTests
    {
        [Fact]
        public async void ComputerWith20DollorsRam_ShouldCalculate20Price()
        {
            var pc = new Composite
            {
                Name = "Computer"
            };
            pc.AddComponent(new Leaf
            {
                Name = "Ram",
                Price = 20
            });

            var price = await pc.CalculatePrice();

            Assert.Equal(20, price);
        }
    }
}