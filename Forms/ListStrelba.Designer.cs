namespace str.Forms
{
    partial class ListStrelba
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
            this.StrGrid = new System.Windows.Forms.DataGridView();
            this.idStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zacatekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zbranidZbrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamestnanecidZamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakaznikidZakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prostoridSprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strelbaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StrGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strelbaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StrGrid
            // 
            this.StrGrid.AllowUserToAddRows = false;
            this.StrGrid.AllowUserToDeleteRows = false;
            this.StrGrid.AutoGenerateColumns = false;
            this.StrGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StrGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStrDataGridViewTextBoxColumn,
            this.zacatekDataGridViewTextBoxColumn,
            this.konecDataGridViewTextBoxColumn,
            this.zbranidZbrDataGridViewTextBoxColumn,
            this.zamestnanecidZamDataGridViewTextBoxColumn,
            this.zakaznikidZakDataGridViewTextBoxColumn,
            this.prostoridSprDataGridViewTextBoxColumn});
            this.StrGrid.DataSource = this.strelbaBindingSource;
            this.StrGrid.Location = new System.Drawing.Point(12, 12);
            this.StrGrid.Name = "StrGrid";
            this.StrGrid.RowTemplate.Height = 24;
            this.StrGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StrGrid.Size = new System.Drawing.Size(776, 312);
            this.StrGrid.TabIndex = 0;
            this.StrGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StrGrid_CellDoubleClick);
            // 
            // idStrDataGridViewTextBoxColumn
            // 
            this.idStrDataGridViewTextBoxColumn.DataPropertyName = "idStr";
            this.idStrDataGridViewTextBoxColumn.HeaderText = "idStr";
            this.idStrDataGridViewTextBoxColumn.Name = "idStrDataGridViewTextBoxColumn";
            // 
            // zacatekDataGridViewTextBoxColumn
            // 
            this.zacatekDataGridViewTextBoxColumn.DataPropertyName = "Zacatek";
            this.zacatekDataGridViewTextBoxColumn.HeaderText = "Zacatek";
            this.zacatekDataGridViewTextBoxColumn.Name = "zacatekDataGridViewTextBoxColumn";
            // 
            // konecDataGridViewTextBoxColumn
            // 
            this.konecDataGridViewTextBoxColumn.DataPropertyName = "Konec";
            this.konecDataGridViewTextBoxColumn.HeaderText = "Konec";
            this.konecDataGridViewTextBoxColumn.Name = "konecDataGridViewTextBoxColumn";
            // 
            // zbranidZbrDataGridViewTextBoxColumn
            // 
            this.zbranidZbrDataGridViewTextBoxColumn.DataPropertyName = "Zbran_idZbr";
            this.zbranidZbrDataGridViewTextBoxColumn.HeaderText = "Zbran_idZbr";
            this.zbranidZbrDataGridViewTextBoxColumn.Name = "zbranidZbrDataGridViewTextBoxColumn";
            // 
            // zamestnanecidZamDataGridViewTextBoxColumn
            // 
            this.zamestnanecidZamDataGridViewTextBoxColumn.DataPropertyName = "Zamestnanec_idZam";
            this.zamestnanecidZamDataGridViewTextBoxColumn.HeaderText = "Zamestnanec_idZam";
            this.zamestnanecidZamDataGridViewTextBoxColumn.Name = "zamestnanecidZamDataGridViewTextBoxColumn";
            // 
            // zakaznikidZakDataGridViewTextBoxColumn
            // 
            this.zakaznikidZakDataGridViewTextBoxColumn.DataPropertyName = "Zakaznik_idZak";
            this.zakaznikidZakDataGridViewTextBoxColumn.HeaderText = "Zakaznik_idZak";
            this.zakaznikidZakDataGridViewTextBoxColumn.Name = "zakaznikidZakDataGridViewTextBoxColumn";
            // 
            // prostoridSprDataGridViewTextBoxColumn
            // 
            this.prostoridSprDataGridViewTextBoxColumn.DataPropertyName = "Prostor_idSpr";
            this.prostoridSprDataGridViewTextBoxColumn.HeaderText = "Prostor_idSpr";
            this.prostoridSprDataGridViewTextBoxColumn.Name = "prostoridSprDataGridViewTextBoxColumn";
            // 
            // strelbaBindingSource
            // 
            this.strelbaBindingSource.DataSource = typeof(str.Strelba);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nová střelba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Pročisti střelby";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListStrelba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StrGrid);
            this.Name = "ListStrelba";
            this.Text = "ListStrelba";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.StrGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strelbaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StrGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zacatekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zbranidZbrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zamestnanecidZamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakaznikidZakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prostoridSprDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource strelbaBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}