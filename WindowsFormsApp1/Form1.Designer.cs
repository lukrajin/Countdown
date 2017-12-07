﻿namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.minout = new System.Windows.Forms.TextBox();
            this.secout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minin = new System.Windows.Forms.NumericUpDown();
            this.secin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.minin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secin)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(57, 150);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 35);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stop
            // 
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(137, 150);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(74, 35);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // minout
            // 
            this.minout.BackColor = System.Drawing.Color.White;
            this.minout.Enabled = false;
            this.minout.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minout.Location = new System.Drawing.Point(56, 38);
            this.minout.MaxLength = 3;
            this.minout.Name = "minout";
            this.minout.Size = new System.Drawing.Size(75, 47);
            this.minout.TabIndex = 4;
            this.minout.Text = "00";
            this.minout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secout
            // 
            this.secout.BackColor = System.Drawing.Color.White;
            this.secout.Enabled = false;
            this.secout.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secout.Location = new System.Drawing.Point(137, 38);
            this.secout.MaxLength = 2;
            this.secout.Name = "secout";
            this.secout.Size = new System.Drawing.Size(75, 47);
            this.secout.TabIndex = 5;
            this.secout.Text = "00";
            this.secout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(73, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(154, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "sec";
            // 
            // minin
            // 
            this.minin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minin.Location = new System.Drawing.Point(57, 115);
            this.minin.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.minin.Name = "minin";
            this.minin.Size = new System.Drawing.Size(75, 29);
            this.minin.TabIndex = 8;
            this.minin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secin
            // 
            this.secin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secin.Location = new System.Drawing.Point(138, 115);
            this.secin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secin.Name = "secin";
            this.secin.Size = new System.Drawing.Size(74, 29);
            this.secin.TabIndex = 9;
            this.secin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 261);
            this.Controls.Add(this.secin);
            this.Controls.Add(this.minin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secout);
            this.Controls.Add(this.minout);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(285, 300);
            this.Name = "Form1";
            this.Text = "Countdown";
            ((System.ComponentModel.ISupportInitialize)(this.minin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TextBox minout;
        private System.Windows.Forms.TextBox secout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown minin;
        private System.Windows.Forms.NumericUpDown secin;
    }
}
