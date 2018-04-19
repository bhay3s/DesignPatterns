using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IRepository : IDisposable
    {
        void SomeMethod();
    }

    public interface IRepositoryFactory
    {
        IRepository Create(object something);
    }

    public class MyRepository : IRepository
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void SomeMethod()
        {
            Console.WriteLine("some method called");
        }
    }

    public class RepositoryFactory : IRepositoryFactory
    {
        public IRepository Create(object something)
        {
            switch (something)
            {
                case "":
                default:
                    return new MyRepository();
            }
        }
    }

    public class MyClass
    {
        private readonly IRepositoryFactory _repositoryFactory;

        public MyClass(IRepositoryFactory repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
        }

        public void GetSomething()
        {
            using (var repository = _repositoryFactory.Create(null))
            {
                repository.SomeMethod();
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var repoFactory = new RepositoryFactory();
            var myclass = new MyClass(repoFactory);
            myclass.GetSomething();
        }
    }
}
