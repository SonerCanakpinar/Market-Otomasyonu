using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Models
{
   public class Siparis
    {
        [Key]
        public int SiparisID { get; set; }
        public DateTime? SiparisTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public decimal? Freight { get; set; }
        public decimal Total { get; set; }
        public float Discount { get; set; }
        
        public string Customer { get; set; }
        public string Shipper { get; set; }
    }
}
