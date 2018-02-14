using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Market.WFA.UI
{
    public partial class FormKullanici : DevExpress.XtraEditors.XtraForm
    {
        public FormKullanici()
        {
            InitializeComponent();
        }

        private void btnKayd_Click(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}