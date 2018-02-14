using Market.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Models
{
    [Table("SiparisDetaylari")]

    public class SiparisDetay
    {
   
        [Key]
        [Column(Order = 1)]
        public int SiparisID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int UrunID { get; set; }

        [ForeignKey("SiparisID")]
        public virtual Siparis Siparis { get; set; }
        [ForeignKey("UrunID")]
        public virtual Urun Urun { get; set; }

        public decimal BirimFiyat { get; set; } = 0;
        public short Adet { get; set; } = 1;
        public float Discount { get; set; } = 0;

     //   public Enum SiparisTuru { get; set; }



    }
}
