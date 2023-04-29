using CompositeDesignPattern.Abstractions;

namespace CompositeDesignPattern.Implementations
{
    public class Composite : IComposite
    {
        public string Name { get; set; }
        protected readonly List<IComponent> _components = new List<IComponent>();
        public async Task AddComponent(IComponent component)
        {
            _components.Add(component);
        }

        public async Task<int> CalculatePrice()
        {
            int price = 0;
            foreach (var component in _components)
                price += await component.CalculatePrice();
            return price;
        }
    }
}
