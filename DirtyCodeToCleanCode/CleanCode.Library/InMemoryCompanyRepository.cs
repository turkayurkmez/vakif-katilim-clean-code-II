using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Library
{
    public class InMemoryCompanyRepository : IRepository<Company>
    {
        public IList<Company> GetAll()
        {
            return new List<Company>(){
                new(){ Name="Acme", HourlyPrice=150},
                new(){ Name="ABC", HourlyPrice=125},
                new(){ Name="Ülker", HourlyPrice=100}
            };
        }
    }
}
