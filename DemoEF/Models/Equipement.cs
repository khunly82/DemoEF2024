using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Models
{
    public class Equipement
    {
        [Key]
        public int Id { get; set; }

        public string Nom { get; set; } = null!;
        public decimal Value { get; set; }

        public List<Personnage> Personnages { get; set; } = null!;
    }
}
