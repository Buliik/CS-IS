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
    public partial class ListStrelba : Form
    {
        public ListStrelba()
        {
            InitializeComponent();
            GetData();
        }

        protected void GetData()
        {
            Collection<Strelba> strelbae = StrelbaTable.select();
            BindingList<Strelba> bindingList = new BindingList<Strelba>(strelbae);
            StrGrid.DataSource = bindingList;
        }

        private Strelba GetSelectedStr()
        {
            // The "SelectionMode" property of the data grid view must be set to "FullRowSelect".
            if (StrGrid.SelectedRows.Count == 1)
            {
                Strelba strelba = StrGrid.SelectedRows[0].DataBoundItem as Strelba;
                return strelba;
            }
            else
            {
                return null;
            }
        }
        protected void EditRecord()
        {
            Strelba selectedStr = GetSelectedStr();
            if (selectedStr != null)
            {
                DetailStrelba form = new DetailStrelba();
                if (form.OpenRecord(selectedStr.idStr))
                {
                    form.ShowDialog();
                    GetData();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailStrelba form = new DetailStrelba();
            if (form.OpenRecord(null))
            {
                form.ShowDialog();
                GetData();
            }
        }

        private void StrGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StrelbaTable.clean();
            GetData();
        }
    }
}
