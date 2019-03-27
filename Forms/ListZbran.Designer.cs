namespace str.Forms
{
    partial class ListZbran
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
            this.GridZbr = new System.Windows.Forms.DataGridView();
            this.idZbrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typzbraneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokvyrobyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zbranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridZbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zbranBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridZbr
            // 
            this.GridZbr.AllowUserToAddRows = false;
            this.GridZbr.AllowUserToDeleteRows = false;
            this.GridZbr.AutoGenerateColumns = false;
            this.GridZbr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridZbr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZbrDataGridViewTextBoxColumn,
            this.nazevDataGridViewTextBoxColumn,
            this.typzbraneDataGridViewTextBoxColumn,
            this.razeDataGridViewTextBoxColumn,
            this.rokvyrobyDataGridViewTextBoxColumn});
            this.GridZbr.DataSource = this.zbranBindingSource;
            this.GridZbr.Location = new System.Drawing.Point(12, 12);
            this.GridZbr.Name = "GridZbr";
            this.GridZbr.RowTemplate.Height = 24;
            this.GridZbr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridZbr.ShowEditingIcon = false;
            this.GridZbr.Size = new System.Drawing.Size(725, 267);
            this.GridZbr.TabIndex = 0;
            this.GridZbr.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridZbr_CellDoubleClick);
            // 
            // idZbrDataGridViewTextBoxColumn
            // 
            this.idZbrDataGridViewTextBoxColumn.DataPropertyName = "idZbr";
            this.idZbrDataGridViewTextBoxColumn.HeaderText = "idZbr";
            this.idZbrDataGridViewTextBoxColumn.Name = "idZbrDataGridViewTextBoxColumn";
            // 
            // nazevDataGridViewTextBoxColumn
            // 
            this.nazevDataGridViewTextBoxColumn.DataPropertyName = "Nazev";
            this.nazevDataGridViewTextBoxColumn.HeaderText = "Nazev";
            this.nazevDataGridViewTextBoxColumn.Name = "nazevDataGridViewTextBoxColumn";
            // 
            // typzbraneDataGridViewTextBoxColumn
            // 
            this.typzbraneDataGridViewTextBoxColumn.DataPropertyName = "Typ_zbrane";
            this.typzbraneDataGridViewTextBoxColumn.HeaderText = "Typ_zbrane";
            this.typzbraneDataGridViewTextBoxColumn.Name = "typzbraneDataGridViewTextBoxColumn";
            // 
            // razeDataGridViewTextBoxColumn
            // 
            this.razeDataGridViewTextBoxColumn.DataPropertyName = "Raze";
            this.razeDataGridViewTextBoxColumn.HeaderText = "Raze";
            this.razeDataGridViewTextBoxColumn.Name = "razeDataGridViewTextBoxColumn";
            // 
            // rokvyrobyDataGridViewTextBoxColumn
            // 
            this.rokvyrobyDataGridViewTextBoxColumn.DataPropertyName = "Rok_vyroby";
            this.rokvyrobyDataGridViewTextBoxColumn.HeaderText = "Rok_vyroby";
            this.rokvyrobyDataGridViewTextBoxColumn.Name = "rokvyrobyDataGridViewTextBoxColumn";
            // 
            // zbranBindingSource
            // 
            this.zbranBindingSource.DataSource = typeof(str.Zbran);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Přidat záznam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListZbran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GridZbr);
            this.Name = "ListZbran";
            this.Text = "ListZbran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListZbran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridZbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zbranBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridZbr;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZbrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typzbraneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokvyrobyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zbranBindingSource;
        private System.Windows.Forms.Button button1;
    }
}