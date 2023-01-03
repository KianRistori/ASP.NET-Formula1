using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_Formula1.Models
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName => $"{LastName}, {FirstName}";
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public string TeamName => Team.Name;
        public double Score { get; set; }
    }
}
