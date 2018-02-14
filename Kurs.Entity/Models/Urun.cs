using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Models
{
    [Table("Urunler")]
    public class Urun 
    {
        [Key]
        public int UrunID { get; set; }
        [Required]
        [StringLength(40)]
        public string UrunAdi { get; set; }
     
        public decimal? AlisFiyat { get; set; } = 0;
        public decimal? SatisFiyat { get; set; } = 0;
        public bool SatistaMi { get; set; }
        public string UrunBarkod { get; set; }
        public int KategoriID { get; set; }
    //    public int StokID { get; set; }

        public int TedarikciID { get; set; }
        public byte[] UrunResim { get; set; }
          //  public byte Discounted { get; set; }

        public DateTime? SonKullanmaTarihi { get; set; }


        
    public int? StokMiktari { get; set; } = 0;

        [ForeignKey("KategoriID")]
        public virtual Kategori Kategori { get; set; }
        //[ForeignKey("StokID")]
        //public virtual Stok stok { get; set; }
        [ForeignKey("TedarikciID")]
        public virtual Tedarikci Tedarikci{ get; set; }

        public override string ToString()
        {
            return $"{UrunAdi}";
        }
    }
}
