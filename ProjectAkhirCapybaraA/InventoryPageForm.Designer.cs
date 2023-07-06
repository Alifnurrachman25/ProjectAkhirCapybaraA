namespace ProjectAkhirCapybaraA
{
    partial class InventoryPageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.gudanginventoryDataSet = new ProjectAkhirCapybaraA.gudanginventoryDataSet();
            this.gudanginventoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gudangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gudangTableAdapter = new ProjectAkhirCapybaraA.gudanginventoryDataSetTableAdapters.gudangTableAdapter();
            this.idgudangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namagudangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jalanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudanginventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudanginventoryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data Gudang";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idgudangDataGridViewTextBoxColumn,
            this.namagudangDataGridViewTextBoxColumn,
            this.jalanDataGridViewTextBoxColumn,
            this.kotaDataGridViewTextBoxColumn,
            this.provinsiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gudangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(69, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(665, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Image = global::ProjectAkhirCapybaraA.Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123237;
            this.button1.Location = new System.Drawing.Point(46, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 40);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // gudanginventoryDataSet
            // 
            this.gudanginventoryDataSet.DataSetName = "gudanginventoryDataSet";
            this.gudanginventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gudanginventoryDataSetBindingSource
            // 
            this.gudanginventoryDataSetBindingSource.DataSource = this.gudanginventoryDataSet;
            this.gudanginventoryDataSetBindingSource.Position = 0;
            // 
            // gudangBindingSource
            // 
            this.gudangBindingSource.DataMember = "gudang";
            this.gudangBindingSource.DataSource = this.gudanginventoryDataSet;
            // 
            // gudangTableAdapter
            // 
            this.gudangTableAdapter.ClearBeforeFill = true;
            // 
            // idgudangDataGridViewTextBoxColumn
            // 
            this.idgudangDataGridViewTextBoxColumn.DataPropertyName = "Id_gudang";
            this.idgudangDataGridViewTextBoxColumn.HeaderText = "Id_gudang";
            this.idgudangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idgudangDataGridViewTextBoxColumn.Name = "idgudangDataGridViewTextBoxColumn";
            this.idgudangDataGridViewTextBoxColumn.Width = 125;
            // 
            // namagudangDataGridViewTextBoxColumn
            // 
            this.namagudangDataGridViewTextBoxColumn.DataPropertyName = "Nama_gudang";
            this.namagudangDataGridViewTextBoxColumn.HeaderText = "Nama_gudang";
            this.namagudangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namagudangDataGridViewTextBoxColumn.Name = "namagudangDataGridViewTextBoxColumn";
            this.namagudangDataGridViewTextBoxColumn.Width = 125;
            // 
            // jalanDataGridViewTextBoxColumn
            // 
            this.jalanDataGridViewTextBoxColumn.DataPropertyName = "Jalan";
            this.jalanDataGridViewTextBoxColumn.HeaderText = "Jalan";
            this.jalanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jalanDataGridViewTextBoxColumn.Name = "jalanDataGridViewTextBoxColumn";
            this.jalanDataGridViewTextBoxColumn.Width = 125;
            // 
            // kotaDataGridViewTextBoxColumn
            // 
            this.kotaDataGridViewTextBoxColumn.DataPropertyName = "Kota";
            this.kotaDataGridViewTextBoxColumn.HeaderText = "Kota";
            this.kotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kotaDataGridViewTextBoxColumn.Name = "kotaDataGridViewTextBoxColumn";
            this.kotaDataGridViewTextBoxColumn.Width = 125;
            // 
            // provinsiDataGridViewTextBoxColumn
            // 
            this.provinsiDataGridViewTextBoxColumn.DataPropertyName = "Provinsi";
            this.provinsiDataGridViewTextBoxColumn.HeaderText = "Provinsi";
            this.provinsiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.provinsiDataGridViewTextBoxColumn.Name = "provinsiDataGridViewTextBoxColumn";
            this.provinsiDataGridViewTextBoxColumn.Width = 125;
            // 
            // InventoryPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "InventoryPageForm";
            this.Text = "InventoryPageForm";
            this.Load += new System.EventHandler(this.InventoryPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudanginventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudanginventoryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gudanginventoryDataSetBindingSource;
        private gudanginventoryDataSet gudanginventoryDataSet;
        private System.Windows.Forms.BindingSource gudangBindingSource;
        private gudanginventoryDataSetTableAdapters.gudangTableAdapter gudangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgudangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namagudangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jalanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinsiDataGridViewTextBoxColumn;
    }
}