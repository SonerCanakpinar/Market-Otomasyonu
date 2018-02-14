using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Models
{
    [Table("Müsteriler")]

    public class Musteri
    {
        [Key]
        public int MusteriID { get; set; }

        [Required]
        [StringLength(40)]
        public string MusteriAdi { get; set; }
        [Required]
        [StringLength(40)]
        public string Adres { get; set; }

        public string Telefon { get; set; }
    }
}
