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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryPageForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idgudangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namagudangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jalanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gudangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gudanginventoryDataSet = new ProjectAkhirCapybaraA.gudanginventoryDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.gudanginventoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gudangTableAdapter = new ProjectAkhirCapybaraA.gudanginventoryDataSetTableAdapters.gudangTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kotaTextBox = new System.Windows.Forms.TextBox();
            this.jalanTextBox = new System.Windows.Forms.TextBox();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.provinsiTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudanginventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudanginventoryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data Gudang";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idgudangDataGridViewTextBoxColumn,
            this.namagudangDataGridViewTextBoxColumn,
            this.jalanDataGridViewTextBoxColumn,
            this.kotaDataGridViewTextBoxColumn,
            this.provinsiDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.gudangBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(71, 151);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(969, 150);
            this.dataGridView.TabIndex = 11;
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
            // gudangBindingSource
            // 
            this.gudangBindingSource.DataMember = "gudang";
            this.gudangBindingSource.DataSource = this.gudanginventoryDataSet;
            // 
            // gudanginventoryDataSet
            // 
            this.gudanginventoryDataSet.DataSetName = "gudanginventoryDataSet";
            this.gudanginventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Image = global::ProjectAkhirCapybaraA.Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123237;
            this.button1.Location = new System.Drawing.Point(40, 873);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 40);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gudanginventoryDataSetBindingSource
            // 
            this.gudanginventoryDataSetBindingSource.DataSource = this.gudanginventoryDataSet;
            this.gudanginventoryDataSetBindingSource.Position = 0;
            // 
            // gudangTableAdapter
            // 
            this.gudangTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Kota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Jalan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nama gudang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Id gudang";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(385, 635);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 57);
            this.button6.TabIndex = 29;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(598, 635);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 57);
            this.button5.TabIndex = 30;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(820, 512);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 57);
            this.button4.TabIndex = 31;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(820, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 57);
            this.button3.TabIndex = 32;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(820, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 57);
            this.button2.TabIndex = 33;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addButton_Click);
            // 
            // kotaTextBox
            // 
            this.kotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gudangBindingSource, "Kota", true));
            this.kotaTextBox.Location = new System.Drawing.Point(372, 497);
            this.kotaTextBox.Name = "kotaTextBox";
            this.kotaTextBox.Size = new System.Drawing.Size(371, 22);
            this.kotaTextBox.TabIndex = 27;
            // 
            // jalanTextBox
            // 
            this.jalanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gudangBindingSource, "Jalan", true));
            this.jalanTextBox.Location = new System.Drawing.Point(372, 445);
            this.jalanTextBox.Name = "jalanTextBox";
            this.jalanTextBox.Size = new System.Drawing.Size(371, 22);
            this.jalanTextBox.TabIndex = 28;
            // 
            // namaTextBox
            // 
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gudangBindingSource, "Nama_gudang", true));
            this.namaTextBox.Location = new System.Drawing.Point(372, 395);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(371, 22);
            this.namaTextBox.TabIndex = 26;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gudangBindingSource, "Id_gudang", true));
            this.idTextBox.Location = new System.Drawing.Point(372, 343);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(371, 22);
            this.idTextBox.TabIndex = 25;
            // 
            // provinsiTextBox
            // 
            this.provinsiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gudangBindingSource, "Provinsi", true));
            this.provinsiTextBox.Location = new System.Drawing.Point(373, 547);
            this.provinsiTextBox.Name = "provinsiTextBox";
            this.provinsiTextBox.Size = new System.Drawing.Size(371, 22);
            this.provinsiTextBox.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Provinsi";
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator.BindingSource = this.gudangBindingSource;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(1128, 27);
            this.bindingNavigator.TabIndex = 38;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // InventoryPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 965);
            this.Controls.Add(this.bindingNavigator);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.provinsiTextBox);
            this.Controls.Add(this.kotaTextBox);
            this.Controls.Add(this.jalanTextBox);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "InventoryPageForm";
            this.Text = "InventoryPageForm";
            this.Load += new System.EventHandler(this.InventoryPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudanginventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudanginventoryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource gudanginventoryDataSetBindingSource;
        private gudanginventoryDataSet gudanginventoryDataSet;
        private System.Windows.Forms.BindingSource gudangBindingSource;
        private gudanginventoryDataSetTableAdapters.gudangTableAdapter gudangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgudangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namagudangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jalanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox kotaTextBox;
        private System.Windows.Forms.TextBox jalanTextBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox provinsiTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}