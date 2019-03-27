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
    public partial class DetailZbran : Form
    {

        private Zbran zbran;
        private bool newRecord;
        public DetailZbran()
        {
            InitializeComponent();
        }

        public bool OpenRecord(object primaryKey)
        {
            if (primaryKey != null)
            {
                int idZbr = (int)primaryKey;
                zbran = ZbranTable.select(idZbr);
                newRecord = false;
            }
            else
            {
                zbran = new Zbran();
                newRecord = true;
            }
            BindData();
            return true;
        }

        private void BindData()
        {
            txtNazev.Text = zbran.Nazev;
            txtTyp.Text = zbran.Typ_zbrane;
            txtRaze.Text = zbran.Raze.ToString();
            txtRok.Text = zbran.Rok_vyroby.ToString();
        }

        private bool GetData()
        {
            zbran.Nazev = txtNazev.Text;
            zbran.Typ_zbrane = txtTyp.Text;
            zbran.Raze = double.Parse(txtRaze.Text);
            zbran.Rok_vyroby = Int32.Parse(txtRok.Text);
            return true;
        }

        protected bool SaveRecord()
        {
            if(GetData())
            {
                if(newRecord)
                {
                    ZbranTable.insert(zbran);
                }
                else
                {
                    ZbranTable.update(zbran);
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
            ZbranTable.delete(zbran.idZbr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveRecord();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void DetailZbran_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
