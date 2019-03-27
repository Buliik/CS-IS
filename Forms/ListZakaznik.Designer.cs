namespace str.Forms
{
    partial class ListZakaznik
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
            this.zakGrid = new System.Windows.Forms.DataGridView();
            this.idZakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijmeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumnarozeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakaznikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zakGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaznikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // zakGrid
            // 
            this.zakGrid.AllowUserToAddRows = false;
            this.zakGrid.AllowUserToDeleteRows = false;
            this.zakGrid.AutoGenerateColumns = false;
            this.zakGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zakGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZakDataGridViewTextBoxColumn,
            this.jmenoDataGridViewTextBoxColumn,
            this.prijmeniDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.datumnarozeniDataGridViewTextBoxColumn});
            this.zakGrid.DataSource = this.zakaznikBindingSource;
            this.zakGrid.Location = new System.Drawing.Point(12, 12);
            this.zakGrid.Name = "zakGrid";
            this.zakGrid.RowTemplate.Height = 24;
            this.zakGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zakGrid.ShowEditingIcon = false;
            this.zakGrid.Size = new System.Drawing.Size(726, 217);
            this.zakGrid.TabIndex = 0;
            this.zakGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.zakGrid_CellDoubleClick);
            // 
            // idZakDataGridViewTextBoxColumn
            // 
            this.idZakDataGridViewTextBoxColumn.DataPropertyName = "idZak";
            this.idZakDataGridViewTextBoxColumn.HeaderText = "idZak";
            this.idZakDataGridViewTextBoxColumn.Name = "idZakDataGridViewTextBoxColumn";
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
            // zakaznikBindingSource
            // 
            this.zakaznikBindingSource.DataSource = typeof(str.Zakaznik);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Přidat zákazníka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListZakaznik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zakGrid);
            this.Name = "ListZakaznik";
            this.Text = "ListZakaznik";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListZakaznik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zakGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaznikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView zakGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijmeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumnarozeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zakaznikBindingSource;
        private System.Windows.Forms.Button button1;
    }
}