using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Library
{
    public class Company : IEntity
    {
        public string Name { get; set; }
        public double HourlyPrice { get; set; }
    }
}
