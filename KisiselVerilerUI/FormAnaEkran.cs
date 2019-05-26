using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiselVerilerUI
{
    public partial class FormAnaEkran : Form
    {
        public FormAnaEkran()
        {
            InitializeComponent();
        }





        private void hobiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHobiler hobiler = new FormHobiler();
            hobiler.MdiParent = this;
            hobiler.Show();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KisiBilgiKayıt kisibilgi = new KisiBilgiKayıt();
            kisibilgi.MdiParent = this;
            kisibilgi.Show();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKisiGörüntüle kisiGörüntüle = new FormKisiGörüntüle();
            kisiGörüntüle.MdiParent = this;
            kisiGörüntüle.Show();
        }

        private void FormAnaEkran_Load(object sender, EventArgs e)
        {
            this.Location = new Point(25, 25);

        }

        private void görüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKisiGuncelle guncelle = new FormKisiGuncelle();
            guncelle.MdiParent = this;
            guncelle.Show();
        }

        private void mesajGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMesajGonder frmMSj = new FormMesajGonder();
            frmMSj.MdiParent = this;
            frmMSj.Show();
        }

        private void hobilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
