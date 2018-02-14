

using Market.Entity.Models;
using System.Data.Entity;

namespace Market.DAL
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyCon")
        {
        }

        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Siparis> Siparisler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<Tedarikci> Tedarikciler { get; set; }
        public virtual DbSet<SiparisDetay> SiparisDetaylari { get; set; }
        public virtual DbSet<Satis> Satislar { get; set; }





    }
}
