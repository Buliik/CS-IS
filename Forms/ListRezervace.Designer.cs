namespace str.Forms
{
    partial class ListRezervace
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
            this.RezGrid = new System.Windows.Forms.DataGridView();
            this.idRezDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumVytvoreniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumStrelbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakaznikidZakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prostoridSprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zbranidZbrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RezGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervaceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RezGrid
            // 
            this.RezGrid.AllowUserToAddRows = false;
            this.RezGrid.AllowUserToDeleteRows = false;
            this.RezGrid.AutoGenerateColumns = false;
            this.RezGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RezGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRezDataGridViewTextBoxColumn,
            this.datumVytvoreniDataGridViewTextBoxColumn,
            this.datumStrelbyDataGridViewTextBoxColumn,
            this.zakaznikidZakDataGridViewTextBoxColumn,
            this.prostoridSprDataGridViewTextBoxColumn,
            this.zbranidZbrDataGridViewTextBoxColumn});
            this.RezGrid.DataSource = this.rezervaceBindingSource;
            this.RezGrid.Location = new System.Drawing.Point(12, 12);
            this.RezGrid.Name = "RezGrid";
            this.RezGrid.RowTemplate.Height = 24;
            this.RezGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RezGrid.Size = new System.Drawing.Size(776, 259);
            this.RezGrid.TabIndex = 0;
            this.RezGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RezGrid_CellDoubleClick);
            // 
            // idRezDataGridViewTextBoxColumn
            // 
            this.idRezDataGridViewTextBoxColumn.DataPropertyName = "idRez";
            this.idRezDataGridViewTextBoxColumn.HeaderText = "idRez";
            this.idRezDataGridViewTextBoxColumn.Name = "idRezDataGridViewTextBoxColumn";
            // 
            // datumVytvoreniDataGridViewTextBoxColumn
            // 
            this.datumVytvoreniDataGridViewTextBoxColumn.DataPropertyName = "datumVytvoreni";
            this.datumVytvoreniDataGridViewTextBoxColumn.HeaderText = "datumVytvoreni";
            this.datumVytvoreniDataGridViewTextBoxColumn.Name = "datumVytvoreniDataGridViewTextBoxColumn";
            // 
            // datumStrelbyDataGridViewTextBoxColumn
            // 
            this.datumStrelbyDataGridViewTextBoxColumn.DataPropertyName = "datumStrelby";
            this.datumStrelbyDataGridViewTextBoxColumn.HeaderText = "datumStrelby";
            this.datumStrelbyDataGridViewTextBoxColumn.Name = "datumStrelbyDataGridViewTextBoxColumn";
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
            // zbranidZbrDataGridViewTextBoxColumn
            // 
            this.zbranidZbrDataGridViewTextBoxColumn.DataPropertyName = "Zbran_idZbr";
            this.zbranidZbrDataGridViewTextBoxColumn.HeaderText = "Zbran_idZbr";
            this.zbranidZbrDataGridViewTextBoxColumn.Name = "zbranidZbrDataGridViewTextBoxColumn";
            // 
            // rezervaceBindingSource
            // 
            this.rezervaceBindingSource.DataSource = typeof(str.Rezervace);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nová rezervace";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Pročisti rezervace";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListRezervace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RezGrid);
            this.Name = "ListRezervace";
            this.Text = "ListRezervace";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListRezervace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RezGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervaceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RezGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRezDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumVytvoreniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumStrelbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakaznikidZakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prostoridSprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zbranidZbrDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rezervaceBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}