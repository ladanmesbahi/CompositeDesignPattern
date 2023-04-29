using CompositeDesignPattern.Abstractions;

namespace CompositeDesignPattern.Implementations
{
    public class Leaf : IComponent
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public async Task<int> CalculatePrice() => Price;
    }
}
