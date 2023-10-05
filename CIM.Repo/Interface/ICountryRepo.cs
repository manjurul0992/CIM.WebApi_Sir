using CIM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIM.Repo.Interface
{
    public interface ICountryRepo
    {
        IEnumerable<Country> GetCountries();
        void SaveCountry(Country country);
    }
}
