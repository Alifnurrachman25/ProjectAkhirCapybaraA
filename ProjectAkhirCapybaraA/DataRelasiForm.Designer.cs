namespace ProjectAkhirCapybaraA
{
    partial class DataRelasiForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Welcome, Capybara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 59);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data relasi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 53);
            this.button1.TabIndex = 18;
            this.button1.Text = "Kepemilikan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnKepemilikan_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(524, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 53);
            this.button2.TabIndex = 18;
            this.button2.Text = "Dikirim";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDikirim_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(159, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 53);
            this.button3.TabIndex = 18;
            this.button3.Text = "Pengelolaan";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnPengelolaan_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(524, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 53);
            this.button4.TabIndex = 18;
            this.button4.Text = "Kedatangan";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnKedatangan_Click);
            // 
            // button6
            // 
            this.button6.Image = global::ProjectAkhirCapybaraA.Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123237;
            this.button6.Location = new System.Drawing.Point(33, 492);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 40);
            this.button6.TabIndex = 17;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DataRelasiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 558);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DataRelasiForm";
            this.Text = "DataRelasiForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}