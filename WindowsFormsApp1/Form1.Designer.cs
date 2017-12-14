namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.minout = new System.Windows.Forms.TextBox();
            this.secout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minin = new System.Windows.Forms.NumericUpDown();
            this.secin = new System.Windows.Forms.NumericUpDown();
            this.mode = new System.Windows.Forms.GroupBox();
            this.stopwatch = new System.Windows.Forms.RadioButton();
            this.countdown = new System.Windows.Forms.RadioButton();
            this.times = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secin)).BeginInit();
            this.mode.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Location = new System.Drawing.Point(38, 150);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(91, 35);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(135, 150);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(91, 35);
            this.stop.TabIndex = 2;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // minout
            // 
            this.minout.BackColor = System.Drawing.Color.White;
            this.minout.Enabled = false;
            this.minout.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minout.Location = new System.Drawing.Point(39, 38);
            this.minout.MaxLength = 3;
            this.minout.Name = "minout";
            this.minout.Size = new System.Drawing.Size(90, 47);
            this.minout.TabIndex = 4;
            this.minout.Text = "00";
            this.minout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secout
            // 
            this.secout.BackColor = System.Drawing.Color.White;
            this.secout.Enabled = false;
            this.secout.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secout.Location = new System.Drawing.Point(135, 38);
            this.secout.MaxLength = 2;
            this.secout.Name = "secout";
            this.secout.Size = new System.Drawing.Size(90, 47);
            this.secout.TabIndex = 5;
            this.secout.Text = "00";
            this.secout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(64, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(160, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "sec";
            // 
            // minin
            // 
            this.minin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minin.Location = new System.Drawing.Point(39, 116);
            this.minin.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.minin.Name = "minin";
            this.minin.Size = new System.Drawing.Size(90, 29);
            this.minin.TabIndex = 8;
            this.minin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minin.ValueChanged += new System.EventHandler(this.secin_ValueChanged);
            // 
            // secin
            // 
            this.secin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secin.Location = new System.Drawing.Point(135, 116);
            this.secin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secin.Name = "secin";
            this.secin.Size = new System.Drawing.Size(90, 29);
            this.secin.TabIndex = 9;
            this.secin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.secin.ValueChanged += new System.EventHandler(this.secin_ValueChanged);
            // 
            // mode
            // 
            this.mode.Controls.Add(this.stopwatch);
            this.mode.Controls.Add(this.countdown);
            this.mode.Location = new System.Drawing.Point(12, 191);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(245, 58);
            this.mode.TabIndex = 10;
            this.mode.TabStop = false;
            this.mode.Text = "Mode";
            // 
            // stopwatch
            // 
            this.stopwatch.AutoSize = true;
            this.stopwatch.Location = new System.Drawing.Point(91, 35);
            this.stopwatch.Name = "stopwatch";
            this.stopwatch.Size = new System.Drawing.Size(76, 17);
            this.stopwatch.TabIndex = 1;
            this.stopwatch.Text = "Stopwatch";
            this.stopwatch.UseVisualStyleBackColor = true;
            this.stopwatch.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // countdown
            // 
            this.countdown.AutoSize = true;
            this.countdown.Checked = true;
            this.countdown.Location = new System.Drawing.Point(6, 35);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(79, 17);
            this.countdown.TabIndex = 0;
            this.countdown.TabStop = true;
            this.countdown.Text = "Countdown";
            this.countdown.UseVisualStyleBackColor = true;
            // 
            // times
            // 
            this.times.ContextMenuStrip = this.contextMenuStrip1;
            this.times.FormattingEnabled = true;
            this.times.Location = new System.Drawing.Point(39, 115);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(90, 30);
            this.times.TabIndex = 11;
            this.times.Visible = false;
            this.times.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 26);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // add
            // 
            this.add.Enabled = false;
            this.add.Location = new System.Drawing.Point(135, 114);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(41, 32);
            this.add.TabIndex = 12;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Visible = false;
            this.add.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // delete
            // 
            this.delete.Enabled = false;
            this.delete.Location = new System.Drawing.Point(185, 114);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(41, 32);
            this.delete.TabIndex = 13;
            this.delete.Text = "-";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.times);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.secin);
            this.Controls.Add(this.minin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secout);
            this.Controls.Add(this.minout);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 300);
            this.MinimumSize = new System.Drawing.Size(280, 300);
            this.Name = "Form1";
            this.Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)(this.minin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secin)).EndInit();
            this.mode.ResumeLayout(false);
            this.mode.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox minout;
        private System.Windows.Forms.TextBox secout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown minin;
        private System.Windows.Forms.NumericUpDown secin;
        private System.Windows.Forms.GroupBox mode;
        private System.Windows.Forms.RadioButton stopwatch;
        private System.Windows.Forms.RadioButton countdown;
        private System.Windows.Forms.ListBox times;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

