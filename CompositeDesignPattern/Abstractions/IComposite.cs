namespace CompositeDesignPattern.Abstractions
{
    public interface IComposite : IComponent
    {
        Task AddComponent(IComponent component);
    }
}
