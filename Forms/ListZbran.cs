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
    public partial class ListZbran : Form
    {
        public ListZbran()
        {
            InitializeComponent();
            GetData();
        }

        protected void GetData()
        {
            Collection<Zbran> zbrane = ZbranTable.select();
            BindingList<Zbran> bindingList = new BindingList<Zbran>(zbrane);
            GridZbr.DataSource = bindingList;
        }

        private Zbran GetSelectedZbr()
        {
            // The "SelectionMode" property of the data grid view must be set to "FullRowSelect".
            if (GridZbr.SelectedRows.Count == 1)
            {
                Zbran zbran = GridZbr.SelectedRows[0].DataBoundItem as Zbran;
                return zbran;
            }
            else
            {
                return null;
            }
        }
        protected void EditRecord()
        {
            Zbran selectedZbr = GetSelectedZbr();
            if (selectedZbr != null)
            {
                DetailZbran form = new DetailZbran();
                if (form.OpenRecord(selectedZbr.idZbr))
                {
                    form.ShowDialog();
                    GetData();
                }
            }
        }

        private void GridZbr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditRecord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailZbran form = new DetailZbran();
            if(form.OpenRecord(null))
            {
                form.ShowDialog();
                GetData();
            }
        }

        private void ListZbran_Load(object sender, EventArgs e)
        {

        }
        
    }
}
