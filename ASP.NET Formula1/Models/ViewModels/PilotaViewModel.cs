using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Formula1.Models
{
    public class PilotaViewModel
    {
        [Required(ErrorMessage = "*jknrfgjklsdfnlsdbnkjbs")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "*")]
        public string FirstName { get; set; }

        public string FullName => $"{LastName}, {FirstName}";
        
        public int TeamId { get; set; }

        [Required(ErrorMessage = "*")]
        public IEnumerable<Team> Teams { get; set; }

        public double Score { get; set; }
    }
}
