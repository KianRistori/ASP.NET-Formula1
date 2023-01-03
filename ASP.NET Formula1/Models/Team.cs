
namespace ASP.NET_Formula1.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public int EngineId { get; set; }
        public virtual Engine Engine { get; set; }
        public string EngineName => Engine.Name;

    }
}
