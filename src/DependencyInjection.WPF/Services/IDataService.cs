using DependencyInjection.WPF.Models;
using System.Collections.Generic;

namespace DependencyInjection.WPF.Services
{
    public interface IDataService
    {
        IEnumerable<PersonModel> GetAll();
    }
}
