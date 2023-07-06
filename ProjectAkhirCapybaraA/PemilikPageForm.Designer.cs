namespace ProjectAkhirCapybaraA
{
    partial class PemilikPageForm
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
            this.gudanginventoryDataSet = new ProjectAkhirCapybaraA.gudanginventoryDataSet();
            this.pemilikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pemilikTableAdapter = new ProjectAkhirCapybaraA.gudanginventoryDataSetTableAdapters.pemilikTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memilikiTableAdapter = new ProjectAkhirCapybaraA.gudanginventoryDataSetTableAdapters.memilikiTableAdapter();
            this.idkepemilikanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpemilikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKmemilikiIdpem403A8C7DBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gudanginventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKmemilikiIdpem403A8C7DBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 59);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Pemilik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gudanginventoryDataSet
            // 
            this.gudanginventoryDataSet.DataSetName = "gudanginventoryDataSet";
            this.gudanginventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pemilikBindingSource
            // 
            this.pemilikBindingSource.DataMember = "pemilik";
            this.pemilikBindingSource.DataSource = this.gudanginventoryDataSet;
            // 
            // pemilikTableAdapter
            // 
            this.pemilikTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkepemilikanDataGridViewTextBoxColumn,
            this.idpemilikDataGridViewTextBoxColumn,
            this.idbarangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKmemilikiIdpem403A8C7DBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(188, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // memilikiTableAdapter
            // 
            this.memilikiTableAdapter.ClearBeforeFill = true;
            // 
            // idkepemilikanDataGridViewTextBoxColumn
            // 
            this.idkepemilikanDataGridViewTextBoxColumn.DataPropertyName = "Id_kepemilikan";
            this.idkepemilikanDataGridViewTextBoxColumn.HeaderText = "Id_kepemilikan";
            this.idkepemilikanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idkepemilikanDataGridViewTextBoxColumn.Name = "idkepemilikanDataGridViewTextBoxColumn";
            this.idkepemilikanDataGridViewTextBoxColumn.Width = 125;
            // 
            // idpemilikDataGridViewTextBoxColumn
            // 
            this.idpemilikDataGridViewTextBoxColumn.DataPropertyName = "Id_pemilik";
            this.idpemilikDataGridViewTextBoxColumn.HeaderText = "Id_pemilik";
            this.idpemilikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpemilikDataGridViewTextBoxColumn.Name = "idpemilikDataGridViewTextBoxColumn";
            this.idpemilikDataGridViewTextBoxColumn.Width = 125;
            // 
            // idbarangDataGridViewTextBoxColumn
            // 
            this.idbarangDataGridViewTextBoxColumn.DataPropertyName = "Id_barang";
            this.idbarangDataGridViewTextBoxColumn.HeaderText = "Id_barang";
            this.idbarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbarangDataGridViewTextBoxColumn.Name = "idbarangDataGridViewTextBoxColumn";
            this.idbarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // fKmemilikiIdpem403A8C7DBindingSource
            // 
            this.fKmemilikiIdpem403A8C7DBindingSource.DataMember = "FK__memiliki__Id_pem__403A8C7D";
            this.fKmemilikiIdpem403A8C7DBindingSource.DataSource = this.pemilikBindingSource;
            // 
            // button1
            // 
            this.button1.Image = global::ProjectAkhirCapybaraA.Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123237;
            this.button1.Location = new System.Drawing.Point(48, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 40);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PemilikPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "PemilikPageForm";
            this.Text = "PemilikPageForm";
            this.Load += new System.EventHandler(this.PemilikPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gudanginventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKmemilikiIdpem403A8C7DBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private gudanginventoryDataSet gudanginventoryDataSet;
        private System.Windows.Forms.BindingSource pemilikBindingSource;
        private gudanginventoryDataSetTableAdapters.pemilikTableAdapter pemilikTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fKmemilikiIdpem403A8C7DBindingSource;
        private gudanginventoryDataSetTableAdapters.memilikiTableAdapter memilikiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkepemilikanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpemilikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarangDataGridViewTextBoxColumn;
    }
}