namespace str.Forms
{
    partial class ListProstor
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
            this.SprGrid = new System.Windows.Forms.DataGridView();
            this.idSprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vzdalenostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prostorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SprGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prostorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SprGrid
            // 
            this.SprGrid.AllowUserToAddRows = false;
            this.SprGrid.AllowUserToDeleteRows = false;
            this.SprGrid.AutoGenerateColumns = false;
            this.SprGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SprGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSprDataGridViewTextBoxColumn,
            this.vzdalenostDataGridViewTextBoxColumn});
            this.SprGrid.DataSource = this.prostorBindingSource;
            this.SprGrid.Location = new System.Drawing.Point(12, 12);
            this.SprGrid.Name = "SprGrid";
            this.SprGrid.RowTemplate.Height = 24;
            this.SprGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SprGrid.Size = new System.Drawing.Size(378, 214);
            this.SprGrid.TabIndex = 0;
            this.SprGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SprGrid_CellDoubleClick);
            // 
            // idSprDataGridViewTextBoxColumn
            // 
            this.idSprDataGridViewTextBoxColumn.DataPropertyName = "idSpr";
            this.idSprDataGridViewTextBoxColumn.HeaderText = "idSpr";
            this.idSprDataGridViewTextBoxColumn.Name = "idSprDataGridViewTextBoxColumn";
            // 
            // vzdalenostDataGridViewTextBoxColumn
            // 
            this.vzdalenostDataGridViewTextBoxColumn.DataPropertyName = "vzdalenost";
            this.vzdalenostDataGridViewTextBoxColumn.HeaderText = "vzdalenost";
            this.vzdalenostDataGridViewTextBoxColumn.Name = "vzdalenostDataGridViewTextBoxColumn";
            // 
            // prostorBindingSource
            // 
            this.prostorBindingSource.DataSource = typeof(str.Prostor);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nový prostor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListProstor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SprGrid);
            this.Name = "ListProstor";
            this.Text = "ListProstor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.SprGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prostorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SprGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vzdalenostDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prostorBindingSource;
        private System.Windows.Forms.Button button1;
    }
}