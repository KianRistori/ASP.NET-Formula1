using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Formula1.Models
{
    public class ScuderiaViewModel
    {
        public IEnumerable<Engine> engines { get; set; }
        public string TeamName { get; set; }
        public int EngineId { get; set; }
    }
}
