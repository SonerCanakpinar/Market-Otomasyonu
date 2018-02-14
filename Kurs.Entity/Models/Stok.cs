using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Models
{
    [Table("Stoklar")]

    public class Stok
    {
        [Key]
        public int StokID { get; set; }
        [Required]
        
        public string UrunBarkod { get; set; }
       // public int UrunID { get; set; }
       // public int KategoriID { get; set; }
       // public int TedarikciID { get; set; }
        public int? StokMiktari { get; set; } = 0;

       // [ForeignKey("UrunID")]
       // public virtual Urun Urun { get; set; }
       // [ForeignKey("KategoriID")]
       // public virtual Kategori Kategori { get; set; }
       // [ForeignKey("TedarikciID")]
       // public virtual Tedarikci Tedarikci { get; set; }

       //// public virtual List<Urun> Urunler { get; set; } = new List<Urun>();

        public override string ToString()
        {
            return $"{StokMiktari}";
        }
    }
}
