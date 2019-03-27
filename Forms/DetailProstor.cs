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
    public partial class DetailProstor : Form
    {
        private Prostor prostor;
        private bool newRecord;
        public DetailProstor()
        {
            InitializeComponent();
        }

        public bool OpenRecord(object primaryKey)
        {
            if (primaryKey != null)
            {
                int idSpr = (int)primaryKey;
                prostor = ProstorTable.select(idSpr);
                newRecord = false;
            }
            else
            {
                prostor = new Prostor();
                newRecord = true;
            }
            BindData();
            return true;
        }

        private void BindData()
        {
            textID.Text = prostor.idSpr.ToString();
            textVzdalenost.Text = prostor.vzdalenost.ToString();
        }

        private bool GetData()
        {
            prostor.vzdalenost = double.Parse(textVzdalenost.Text);
            return true;
        }

        protected bool SaveRecord()
        {
            if (GetData())
            {
                if (newRecord)
                {
                    ProstorTable.insert(prostor);
                }
                else
                {
                    ProstorTable.update(prostor);
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
            ProstorTable.delete(prostor.idSpr);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SaveRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void DetailProstor_Load(object sender, EventArgs e)
        {

        }
    }
}
