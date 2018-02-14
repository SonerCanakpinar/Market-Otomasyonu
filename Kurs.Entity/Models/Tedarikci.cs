using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Models
{
   public class Tedarikci
    {
        [Key]
        public int TedarikciID { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }
        [Required]
        [StringLength(40)]
        public string ContactName { get; set; }
        [Required]
        [StringLength(40)]
        public string Adres { get; set; }

        public virtual List<Urun> Urunler { get; set; } = new List<Urun>();
        public override string ToString()
        {
            return CompanyName;
        }
    }
}
