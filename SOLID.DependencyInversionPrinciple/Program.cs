using System;
using Microsoft.Extensions.DependencyInjection;

namespace SOLID.DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<IRepository, SqlServerRepository>();

            var serviceProvider = services.BuildServiceProvider();
            var userController = serviceProvider.GetService<UserController>();
            var user = userController.Get();

            Console.WriteLine(user);
        }
    }
}
