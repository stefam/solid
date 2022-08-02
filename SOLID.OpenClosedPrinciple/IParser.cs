namespace SOLID.OpenClosedPrinciple
{
    public interface IParser
    {
        string Parse<T>(T obj);
    }
}
