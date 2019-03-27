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
    public partial class DetailRezervace : Form
    {
        private Rezervace rezervace;
        private bool newRecord;
        public DetailRezervace()
        {
            InitializeComponent();
        }

        public bool OpenRecord(object primaryKey)
        {
            if (primaryKey != null)
            {
                int idRez = (int)primaryKey;
                rezervace = RezervaceTable.select(idRez);
                newRecord = false;
            }
            else
            {
                rezervace = new Rezervace();
                rezervace.datumStrelby = new DateTime(2000, 01, 01);
                newRecord = true;
            }
            BindData();
            return true;
        }

        private void BindData()
        {

            Collection<Zakaznik> zakaznici = ZakaznikTable.select();
            Collection<Zbran> zbrane = ZbranTable.select();
            Collection<Prostor> prostory = ProstorTable.select();

            foreach (Zakaznik zakaznik in zakaznici)
            {
                comboBox1.Items.Add(zakaznik.Jmeno + " " + zakaznik.Prijmeni);
            }

            foreach (Zbran zbran in zbrane)
            {
                comboBox2.Items.Add(zbran.Nazev);
            }

            foreach (Prostor prostor in prostory)
            {
                comboBox3.Items.Add(prostor.idSpr.ToString() + " " + prostor.vzdalenost.ToString()) ;
            }

            dateTimePicker2.Value = rezervace.datumStrelby;
        }

        private bool GetData()
        {
            Collection<Zakaznik> zakaznici = ZakaznikTable.select();
            Collection<Zbran> zbrane = ZbranTable.select();
            Collection<Prostor> prostory = ProstorTable.select();
            if (comboBox1.SelectedIndex>=0 && comboBox2.SelectedIndex>=0 && comboBox3.SelectedIndex>=0)
            {
                rezervace.datumVytvoreni = DateTime.Now;
                rezervace.datumStrelby = dateTimePicker2.Value;
                rezervace.Zakaznik_idZak = zakaznici[comboBox1.SelectedIndex].idZak;
                rezervace.Zbran_idZbr = zbrane[comboBox2.SelectedIndex].idZbr;
                rezervace.Prostor_idSpr = prostory[comboBox3.SelectedIndex].idSpr;
                label2.Visible = false;
                return true;
            }

            else
            {
                label2.Visible = true;
                return false;
            }
        }

        protected bool SaveRecord()
        {
            if (GetData())
            {
                if (newRecord)
                {
                    RezervaceTable.insert(rezervace);
                }
                else
                {
                    RezervaceTable.update(rezervace);
                }
                this.Hide();
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void DeleteRecord()
        {
            RezervaceTable.delete(rezervace.idRez);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }
    }
}
