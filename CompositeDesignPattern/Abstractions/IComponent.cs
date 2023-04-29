namespace CompositeDesignPattern.Abstractions
{
    public interface IComponent
    {
        Task<int> CalculatePrice();
    }
}
