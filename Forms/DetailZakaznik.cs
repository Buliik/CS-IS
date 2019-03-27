using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str.Forms
{
    public partial class DetailZakaznik : Form
    {
        private Zakaznik zakaznik;
        private bool newRecord;
        public DetailZakaznik()
        {
            InitializeComponent();
        }

        public bool OpenRecord(object primaryKey)
        {
            if (primaryKey != null)
            {
                int idZak = (int)primaryKey;
                zakaznik = ZakaznikTable.select(idZak);
                newRecord = false;
            }
            else
            {
                zakaznik = new Zakaznik();
                zakaznik.Datum_narozeni = new DateTime(2000, 01, 01);
                newRecord = true;
            }
            BindData();
            return true;
        }

        private void BindData()
        {
            txtJmeno.Text = zakaznik.Jmeno;
            txtPrijmeni.Text = zakaznik.Prijmeni;
            txtEmail.Text = zakaznik.email;
            dtNarozeni.Value = zakaznik.Datum_narozeni;
        }

        private bool GetData()
        {
            zakaznik.Jmeno = txtJmeno.Text;
            zakaznik.Prijmeni = txtPrijmeni.Text;
            zakaznik.email = txtEmail.Text;
            zakaznik.Datum_narozeni = dtNarozeni.Value;
            return true;
        }

        protected bool SaveRecord()
        {
            if (GetData())
            {
                if (newRecord)
                {
                    ZakaznikTable.Insert(zakaznik);
                }
                else
                {
                    ZakaznikTable.update(zakaznik);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void DeleteRecord()
        {
            ZakaznikTable.delete(zakaznik.idZak);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveRecord();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void DetailZakaznik_Load(object sender, EventArgs e)
        {

        }
    }
}
