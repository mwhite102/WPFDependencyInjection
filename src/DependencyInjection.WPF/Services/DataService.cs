using DependencyInjection.WPF.Models;
using System.Collections.Generic;

namespace DependencyInjection.WPF.Services
{
    public class DataService : IDataService
    {
        public IEnumerable<PersonModel> GetAll()
        {
            IEnumerable<PersonModel> result = new List<PersonModel>()
            {
                new PersonModel() { Name = "John Doe", Id = 1 },
                new PersonModel() { Name = "Jane Doe", Id = 2 }
            };

            return result;
        }
    }
}
