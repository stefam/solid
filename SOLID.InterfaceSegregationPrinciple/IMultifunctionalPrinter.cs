namespace SOLID.InterfaceSegregationPrinciple
{
    public interface IMultifunctionalPrinter
    {
        void Print(string content);

        void Scan(string content);

        void Fax(string content);
    }
}
