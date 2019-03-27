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
    public partial class ListProstor : Form
    {
        public ListProstor()
        {
            InitializeComponent();
            GetData();
        }

        protected void GetData()
        {
            Collection<Prostor> spraznici = ProstorTable.select();
            BindingList<Prostor> bindingList = new BindingList<Prostor>(spraznici);
            SprGrid.DataSource = bindingList;
        }

        private Prostor GetSelectedSpr()
        {
            // The "SelectionMode" property of the data grid view must be set to "FullRowSelect".
            if (SprGrid.SelectedRows.Count == 1)
            {
                Prostor prostor = SprGrid.SelectedRows[0].DataBoundItem as Prostor;
                return prostor;
            }
            else
            {
                return null;
            }
        }
        protected void EditRecord()
        {
            Prostor selectedSpr = GetSelectedSpr();
            if (selectedSpr != null)
            {
                DetailProstor form = new DetailProstor();
                if (form.OpenRecord(selectedSpr.idSpr))
                {
                    form.ShowDialog();
                    GetData();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailProstor form = new DetailProstor();
            if (form.OpenRecord(null))
            {
                form.ShowDialog();
                GetData();
            }
        }

        private void SprGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditRecord();
        }
    }
}
