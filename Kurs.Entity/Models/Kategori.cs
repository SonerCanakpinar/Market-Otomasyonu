using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Models
{
    [Table("Kategoriler")]
    public class Kategori 
    {
        [Key]
        public int KategoriID { get; set; }
        [Required]
        [StringLength(30)]
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        public decimal KDV { get; set; }


        public virtual List<Urun> Urunler { get; set; } = new List<Urun>();

        public override string ToString()
        {
            return KategoriAdi;
        }
    }
}
