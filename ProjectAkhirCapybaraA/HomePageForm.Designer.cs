﻿namespace ProjectAkhirCapybaraA
{
    partial class HomePageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data master";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome, Capybara";
            // 
            // button5
            // 
            this.button5.Image = global::ProjectAkhirCapybaraA.Properties.Resources._3289576_individual_man_people_person_107097;
            this.button5.Location = new System.Drawing.Point(347, 213);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 71);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnPemilik_Click);
            // 
            // button4
            // 
            this.button4.Image = global::ProjectAkhirCapybaraA.Properties.Resources.warehouse_122331;
            this.button4.Location = new System.Drawing.Point(129, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 71);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // button3
            // 
            this.button3.Image = global::ProjectAkhirCapybaraA.Properties.Resources.courier_icon_142651;
            this.button3.Location = new System.Drawing.Point(541, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 71);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnKurir_Click);
            // 
            // button2
            // 
            this.button2.Image = global::ProjectAkhirCapybaraA.Properties.Resources.staff_management_icon_148356;
            this.button2.Location = new System.Drawing.Point(541, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 71);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ProjectAkhirCapybaraA.Properties.Resources.goods_icon_148531__1_;
            this.button1.Location = new System.Drawing.Point(129, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 71);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnBarang_Click);
            // 
            // button6
            // 
            this.button6.Image = global::ProjectAkhirCapybaraA.Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123237;
            this.button6.Location = new System.Drawing.Point(12, 398);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 40);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HomePageForm";
            this.Text = "Inventory App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}