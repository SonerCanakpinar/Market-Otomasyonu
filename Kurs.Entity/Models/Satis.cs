using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Models
{
    [Table("Satislar")]

    public class Satis
    {
        [Key]
        public int SatisID { get; set; }
        public int MusteriID { get; set; }
        [ForeignKey("MusteriID")]
        public virtual Musteri Musteri { get; set; }
        public int UrunID { get; set; }
        [ForeignKey(" UrunID")]
        public virtual Urun Urun { get; set; }

        public string UrunAdi { get; set; }
      public short Adet { get; set; } = 1;
        public decimal BirimFiyat { get; set; } = 0;
        public float Discount { get; set; } = 0;
        public decimal Total
        {
            get
            {
                return Adet * BirimFiyat * Convert.ToDecimal(1 - Discount);
            }
        }
        public override string ToString()
        {
            return $"{this.UrunAdi} {Adet}x{BirimFiyat:c2} = {Adet * BirimFiyat * Convert.ToDecimal(1 - Discount):c2}";
        }
    }
}
