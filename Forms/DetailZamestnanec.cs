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
    public partial class DetailZamestnanec : Form
    {
        private Zamestnanec zamestnanec;
        private bool newRecord;
        public DetailZamestnanec()
        {
            InitializeComponent();
        }

        public bool OpenRecord(object primaryKey)
        {
            if (primaryKey != null)
            {
                int idZam = (int)primaryKey;
                zamestnanec = ZamestnanecTable.select(idZam);
                newRecord = false;
            }
            else
            {
                zamestnanec = new Zamestnanec();
                zamestnanec.Datum_narozeni = new DateTime(2000, 01, 01);
                newRecord = true;
            }
            BindData();
            return true;
        }

        private void BindData()
        {
            txtJmeno.Text = zamestnanec.Jmeno;
            txtPrijmeni.Text = zamestnanec.Prijmeni;
            txtEmail.Text = zamestnanec.email;
            dtNarozeni.Value = zamestnanec.Datum_narozeni;
        }

        private bool GetData()
        {
            zamestnanec.Jmeno = txtJmeno.Text;
            zamestnanec.Prijmeni = txtPrijmeni.Text;
            zamestnanec.email = txtEmail.Text;
            zamestnanec.Datum_narozeni = dtNarozeni.Value;
            return true;
        }

        protected bool SaveRecord()
        {
            if (GetData())
            {
                if (newRecord)
                {
                    ZamestnanecTable.insert(zamestnanec);
                }
                else
                {
                    ZamestnanecTable.update(zamestnanec);
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
            ZamestnanecTable.delete(zamestnanec.idZam);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void DetailZamestnanec_Load(object sender, EventArgs e)
        {

        }
    }
}
