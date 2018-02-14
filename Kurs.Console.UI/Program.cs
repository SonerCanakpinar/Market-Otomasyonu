using Market.BLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Market.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var kategoriler = new KategoriRepo().GetAll();
                System.Console.Clear();
                System.Console.Beep(10000, 900);
                kategoriler.ForEach(x => System.Console.WriteLine(x.KategoriAdi + " - " + x.Aciklama));

                Thread.Sleep(1000 * 10);
            }
        }
    }
}
