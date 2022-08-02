namespace SOLID.DependencyInversionPrinciple
{
    public class UserController
    {
        // Before
        private readonly SqlServerRepository _repository;

        public UserController(SqlServerRepository repository)
        {
            _repository = repository;
        }

        public object Get()
        {
            return _repository.GetUser();
        }

        // After
        //private readonly IRepository _repository;

        //public UserController(IRepository repository)
        //{
        //    _repository = repository;
        //}

        //public object Get()
        //{
        //    return _repository.Get<User>();
        //}
    }
}
