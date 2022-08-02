namespace SOLID.DependencyInversionPrinciple
{
    // Before
    //public class SqlServerRepository
    //{
    //    public User GetUser()
    //    {
    //        return new User();
    //    }
    //}

    // After
    public class SqlServerRepository : IRepository
    {
        public T Get<T>()
        {
            return ((T) new object { });
        }
    }
}
