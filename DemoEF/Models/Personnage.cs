using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEF.Models
{
    public class Personnage
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public int PvMax { get; set; }
        public DateTime DateDeCreation { get; set; }

        [Column("Vivant")]
        public bool Alive { get; set; }

        public int JobId { get; set; }

        [ForeignKey("JobId")]
        public Job Job { get; set; } = null!;

        public List<Equipement> Equipements { get; set; } = null!;
    }
}
