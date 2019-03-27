using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace str.Forms
{
    public partial class ListZakaznik : Form
    {
        public ListZakaznik()
        {
            InitializeComponent();
            GetData();
        }

        protected void GetData()
        {
            Collection<Zakaznik> zakaznici = ZakaznikTable.select();
            BindingList<Zakaznik> bindingList = new BindingList<Zakaznik>(zakaznici);
            zakGrid.DataSource = bindingList;
        }

        private Zakaznik GetSelectedZak()
        {
            // The "SelectionMode" property of the data grid view must be set to "FullRowSelect".
            if (zakGrid.SelectedRows.Count == 1)
            {
                Zakaznik zakaznik = zakGrid.SelectedRows[0].DataBoundItem as Zakaznik;
                return zakaznik;
            }
            else
            {
                return null;
            }
        }
        protected void EditRecord()
        {
            Zakaznik selectedZak = GetSelectedZak();
            if (selectedZak != null)
            {
                DetailZakaznik form = new DetailZakaznik();
                if (form.OpenRecord(selectedZak.idZak))
                {
                    form.ShowDialog();
                    GetData();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailZakaznik form = new DetailZakaznik();
            if (form.OpenRecord(null))
            {
                form.ShowDialog();
                GetData();
            }
        }

        private void ListZakaznik_Load(object sender, EventArgs e)
        {

        }

        private void zakGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditRecord();
        }
    }
}
