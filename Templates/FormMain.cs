using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str.Templates
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void zbranToolStripItem_Click(object sender, EventArgs e)
        {
            Forms.ListZbran form = new Forms.ListZbran();
            form.MdiParent = this;
            form.Show();
        }

        private void RezervaceToolStripMenu_Click(object sender, EventArgs e)
        {
            Forms.ListRezervace form = new Forms.ListRezervace();
            form.MdiParent = this;
            form.Show();
        }

        private void zákazníkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.ListZakaznik form = new Forms.ListZakaznik();
            form.MdiParent = this;
            form.Show();
        }

        private void zaměstnanecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.ListZamestnanec form = new Forms.ListZamestnanec();
            form.MdiParent = this;
            form.Show();
        }

        private void střelbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.ListStrelba form = new Forms.ListStrelba();
            form.MdiParent = this;
            form.Show();
        }

        private void prostoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.ListProstor form = new Forms.ListProstor();
            form.MdiParent = this;
            form.Show();
        }
    }
}
