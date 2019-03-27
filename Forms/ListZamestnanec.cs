using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace str.Forms
{
    public partial class ListZamestnanec : Form
    {
        public ListZamestnanec()
        {
            InitializeComponent();
            GetData();
        }

        protected void GetData()
        {
            Collection<Zamestnanec> zamaznici = ZamestnanecTable.select();
            BindingList<Zamestnanec> bindingList = new BindingList<Zamestnanec>(zamaznici);
            zamGrid.DataSource = bindingList;
        }

        private Zamestnanec GetSelectedZam()
        {
            // The "SelectionMode" property of the data grid view must be set to "FullRowSelect".
            if (zamGrid.SelectedRows.Count == 1)
            {
                Zamestnanec zamestnanec = zamGrid.SelectedRows[0].DataBoundItem as Zamestnanec;
                return zamestnanec;
            }
            else
            {
                return null;
            }
        }
        protected void EditRecord()
        {
            Zamestnanec selectedZam = GetSelectedZam();
            if (selectedZam != null)
            {
                DetailZamestnanec form = new DetailZamestnanec();
                if (form.OpenRecord(selectedZam.idZam))
                {
                    form.ShowDialog();
                    GetData();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailZamestnanec form = new DetailZamestnanec();
            if (form.OpenRecord(null))
            {
                form.ShowDialog();
                GetData();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditRecord();
        }

        private void ListZamestnanec_Load(object sender, EventArgs e)
        {

        }
    }
}
