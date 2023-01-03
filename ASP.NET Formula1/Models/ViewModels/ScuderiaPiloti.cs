using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Formula1.Models
{
    public class ScuderiaPiloti
    {
        public IEnumerable<Driver> Drivers { get; set; }
        public string NomeTeam { get; set; }
    }
}
