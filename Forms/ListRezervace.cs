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
    public partial class ListRezervace : Form
    {
        public ListRezervace()
        {
            InitializeComponent();
            GetData();
        }

        protected void GetData()
        {
            Collection<Rezervace> rezervacee = RezervaceTable.select();
            BindingList<Rezervace> bindingList = new BindingList<Rezervace>(rezervacee);
            RezGrid.DataSource = bindingList;
        }

        private Rezervace GetSelectedRez()
        {
            // The "SelectionMode" property of the data grid view must be set to "FullRowSelect".
            if (RezGrid.SelectedRows.Count == 1)
            {
                Rezervace rezervace = RezGrid.SelectedRows[0].DataBoundItem as Rezervace;
                return rezervace;
            }
            else
            {
                return null;
            }
        }
        protected void EditRecord()
        {
            Rezervace selectedRez = GetSelectedRez();
            if (selectedRez != null)
            {
                DetailRezervace form = new DetailRezervace();
                if (form.OpenRecord(selectedRez.idRez))
                {
                    form.ShowDialog();

                    GetData();
                }
            }
        }

        private void ListRezervace_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                DetailRezervace form = new DetailRezervace();
                if (form.OpenRecord(null))
                {
                    form.ShowDialog();
                    GetData();
                }
            }
        }

        private void RezGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RezervaceTable.clean();
            GetData();
        }
    }
}
