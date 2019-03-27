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
    public partial class DetailStrelba : Form
    {
        private Strelba strelba;
        private bool newRecord;
        public DetailStrelba()
        {
            InitializeComponent();
        }

        public bool OpenRecord(object primaryKey)
        {
            if (primaryKey != null)
            {
                int idStr = (int)primaryKey;
                strelba = StrelbaTable.select(idStr);
                newRecord = false;
            }
            else
            {
                strelba = new Strelba();
                strelba.Zacatek = new DateTime(2000, 01, 01);
                strelba.Konec = new DateTime(2000, 01, 01);
                newRecord = true;
            }
            BindData();
            return true;
        }

        private void BindData()
        {

            Collection<Zakaznik> zakaznici = ZakaznikTable.select();
            Collection<Zamestnanec> zamestnanci = ZamestnanecTable.select();
            Collection<Zbran> zbrane = ZbranTable.select();
            Collection<Prostor> prostory = ProstorTable.select();

            foreach (Zakaznik zakaznik in zakaznici)
            {
                comboBox1.Items.Add(zakaznik.Jmeno + " " + zakaznik.Prijmeni);
                if (zakaznik.idZak == strelba.Zakaznik_idZak) comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            }

            foreach (Zamestnanec zamestnanec in zamestnanci)
            {
                comboBox2.Items.Add(zamestnanec.Jmeno + " " + zamestnanec.Prijmeni);
                if (zamestnanec.idZam == strelba.Zamestnanec_idZam) comboBox2.SelectedIndex = comboBox2.Items.Count - 1;
            }

            foreach (Zbran zbran in zbrane)
            {
                comboBox3.Items.Add(zbran.Nazev);
                if (zbran.idZbr == strelba.Zbran_idZbr) comboBox3.SelectedIndex = comboBox3.Items.Count - 1;
            }

            foreach (Prostor prostor in prostory)
            {
                comboBox4.Items.Add(prostor.idSpr.ToString() + " " + prostor.vzdalenost.ToString());
                if (prostor.idSpr == strelba.Prostor_idSpr) comboBox4.SelectedIndex = comboBox4.Items.Count - 1;
            }

            dateTimePicker1.Value = strelba.Zacatek;
            dateTimePicker2.Value = strelba.Konec;
        }

        private bool GetData()
        {
            Collection<Zakaznik> zakaznici = ZakaznikTable.select();
            Collection<Zamestnanec> zamestnanci = ZamestnanecTable.select();
            Collection<Zbran> zbrane = ZbranTable.select();
            Collection<Prostor> prostory = ProstorTable.select();
            strelba.Zacatek = dateTimePicker1.Value;
            strelba.Konec = dateTimePicker2.Value;
            strelba.Zakaznik_idZak = zakaznici[comboBox1.SelectedIndex].idZak;
            strelba.Zamestnanec_idZam = zamestnanci[comboBox2.SelectedIndex].idZam;
            strelba.Zbran_idZbr = zbrane[comboBox3.SelectedIndex].idZbr;
            strelba.Prostor_idSpr = prostory[comboBox4.SelectedIndex].idSpr;
            return true;
        }

        protected bool SaveRecord()
        {
            if (GetData())
            {
                if (newRecord)
                {
                    StrelbaTable.insert(strelba);
                }
                else
                {
                    StrelbaTable.update(strelba);
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
            StrelbaTable.delete(strelba.idStr);
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
