namespace DemoEF.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public List<Personnage> Personnages { get; set; } = null!;
    }
}
