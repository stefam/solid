namespace SOLID.DependencyInversionPrinciple
{
    public interface IRepository
    {
        T Get<T>();
    }
}
