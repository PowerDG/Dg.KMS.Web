using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Mammal
{

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public interface IRepository
    {
        List<Person> GetPersons();
    }
    public class RepositoryBase : IRepository
    {
        public List<Person> Persons { get; set; } = new List<Person>();
        public RepositoryBase()
        {
            for (int i = 0; i < 10; i++)
            {
                Persons.Add(new Person()
                {
                    Id = i + 1,
                    Name = "张三" + i,
                    Age = 10 + i * 2
                });
            }
        }
        public List<Person> GetPersons()
        {
            return Persons;
        }
    }
    public class PersonRepository : RepositoryBase
    {
    }
    public interface IService
    {
        List<Person> GetPersons();
    }
    public class ServiceBase : IService
    {
        public IRepository Repository { get; set; }
        public ServiceBase(IRepository repository)
        {
            Repository = repository;
        }
        public List<Person> GetPersons()
        {
            return Repository.GetPersons();
        }
    }
    public class PersonService : ServiceBase
    {
        public PersonService(IRepository repository) : base(repository)
        {
        }
    }

}
