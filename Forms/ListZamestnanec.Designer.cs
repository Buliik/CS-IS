namespace str.Forms
{
    partial class ListZamestnanec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zamGrid = new System.Windows.Forms.DataGridView();
            this.idZamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijmeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumnarozeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamestnanecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zamGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamestnanecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // zamGrid
            // 
            this.zamGrid.AllowUserToAddRows = false;
            this.zamGrid.AllowUserToDeleteRows = false;
            this.zamGrid.AutoGenerateColumns = false;
            this.zamGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zamGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZamDataGridViewTextBoxColumn,
            this.jmenoDataGridViewTextBoxColumn,
            this.prijmeniDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.datumnarozeniDataGridViewTextBoxColumn});
            this.zamGrid.DataSource = this.zamestnanecBindingSource;
            this.zamGrid.Location = new System.Drawing.Point(32, 61);
            this.zamGrid.Name = "zamGrid";
            this.zamGrid.RowTemplate.Height = 24;
            this.zamGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zamGrid.Size = new System.Drawing.Size(727, 245);
            this.zamGrid.TabIndex = 0;
            this.zamGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idZamDataGridViewTextBoxColumn
            // 
            this.idZamDataGridViewTextBoxColumn.DataPropertyName = "idZam";
            this.idZamDataGridViewTextBoxColumn.HeaderText = "idZam";
            this.idZamDataGridViewTextBoxColumn.Name = "idZamDataGridViewTextBoxColumn";
            // 
            // jmenoDataGridViewTextBoxColumn
            // 
            this.jmenoDataGridViewTextBoxColumn.DataPropertyName = "Jmeno";
            this.jmenoDataGridViewTextBoxColumn.HeaderText = "Jmeno";
            this.jmenoDataGridViewTextBoxColumn.Name = "jmenoDataGridViewTextBoxColumn";
            // 
            // prijmeniDataGridViewTextBoxColumn
            // 
            this.prijmeniDataGridViewTextBoxColumn.DataPropertyName = "Prijmeni";
            this.prijmeniDataGridViewTextBoxColumn.HeaderText = "Prijmeni";
            this.prijmeniDataGridViewTextBoxColumn.Name = "prijmeniDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // datumnarozeniDataGridViewTextBoxColumn
            // 
            this.datumnarozeniDataGridViewTextBoxColumn.DataPropertyName = "Datum_narozeni";
            this.datumnarozeniDataGridViewTextBoxColumn.HeaderText = "Datum_narozeni";
            this.datumnarozeniDataGridViewTextBoxColumn.Name = "datumnarozeniDataGridViewTextBoxColumn";
            // 
            // zamestnanecBindingSource
            // 
            this.zamestnanecBindingSource.DataSource = typeof(str.Zamestnanec);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Přidat zaměstnance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListZamestnanec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zamGrid);
            this.Name = "ListZamestnanec";
            this.Text = "ListZamestnanec";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListZamestnanec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zamGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamestnanecBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView zamGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijmeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumnarozeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zamestnanecBindingSource;
        private System.Windows.Forms.Button button1;
    }
}