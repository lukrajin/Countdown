using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int counter;
        private Timer timer1;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Start.Text == "Start")
            {
                if (radioButton2.Checked == true)
                {
                    
                    groupBox1.Enabled = false;
                    Start.Text = "Pause";
                    timer1 = new System.Windows.Forms.Timer();
                    Stop.Enabled = true;
                    timer1.Tick += new EventHandler(timer1_Tick2);
                    timer1.Interval = 1000;
                    timer1.Start();
                }
                else
                {
                    if (minin.Value != 0 || secin.Value != 0)
                    {
                        groupBox1.Enabled = false;
                        Start.Text = "Pause";
                        minin.Enabled = false;
                        secin.Enabled = false;

                        timer1 = new System.Windows.Forms.Timer();
                        counter = (int)secin.Value;
                        int m = (int)minin.Value;
                        if (m < 10)
                            minout.Text = "0" + m.ToString();
                        else
                            minout.Text = m.ToString();

                        Stop.Enabled = true;
                        timer1.Tick += new EventHandler(timer1_Tick);
                        timer1.Interval = 1000;
                        timer1.Start();


                        if (secin.Value < 10)
                            secout.Text = "0" + counter.ToString();
                        else
                            secout.Text = counter.ToString();
                        if (secin.Value < 10)
                            secout.Text = "0" + counter.ToString();
                        else
                            secout.Text = counter.ToString();
                    }
                }
            }
            else if (Start.Text == "Pause")
            {
                Start.Text = "Continue";
                timer1.Stop();
            }
            else if (Start.Text == "Continue")
            {
                Start.Text = "Pause";
                timer1.Start();
            }

            
           
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (int.Parse(minout.Text) < 5)
            {
                if (minout.BackColor == Color.White)
                {
                    minout.BackColor = Color.Orange;
                    secout.BackColor = Color.Orange;
                }
                else
                {
                    minout.BackColor = Color.White;
                    secout.BackColor = Color.White;
                }
            }

            if (int.Parse(minout.Text) == 0 && int.Parse(secout.Text) == 0)
            {
                
                minout.Text = "00";
                secout.Text = "00";
                Start.Text = "Start";
                minout.BackColor = Color.White;
                secout.BackColor = Color.White;
                timer1.Stop();
                minin.Enabled = true;
                secin.Enabled = true;
                Stop.Enabled = false;
                Start.Enabled = true;
                groupBox1.Enabled = true;

            }
            else if (counter == 0)
            {
                int m = int.Parse(minout.Text) - 1;
                if (m < 10)
                    minout.Text = "0"+m.ToString();
                else
                    minout.Text =m.ToString();
                counter = 59;
                secout.Text = counter.ToString();
            }
            else
            {
                counter--;
              
                if (counter < 10)
                    secout.Text = "0" + counter.ToString();
                else
                    secout.Text = counter.ToString();
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


                Start.Text = "Start";
                Start.Enabled = true;
                timer1.Stop();
                counter = 0;
                groupBox1.Enabled = true;

                Stop.Enabled = false;
                minin.Enabled = true;
                secin.Enabled = true;
                minout.Text = "00";
                secout.Text = "00";
                minout.BackColor = Color.White;
                secout.BackColor = Color.White;



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                minin.Visible = false;
                secin.Visible = false;
                listBox1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
            }
            else
            {
                minin.Visible = true;
                secin.Visible = true;
                listBox1.Visible = false;
                button1.Visible =false;
                button2.Visible = false;
            }
           
        }
        private void timer1_Tick2(object sender, EventArgs e)
        {

            if (int.Parse(minout.Text) == 999 && int.Parse(secout.Text) == 59)
            {

                minout.Text = "00";
                secout.Text = "00";
                Start.Text = "Start";
                minout.BackColor = Color.White;
                secout.BackColor = Color.White;
                timer1.Stop();
                minin.Enabled = true;
                secin.Enabled = true;
                Stop.Enabled = false;
                Start.Enabled = true;
                groupBox1.Enabled = true;

            }
            else if (counter == 59)
            {
                int m = int.Parse(minout.Text) + 1;
                if (m < 10)
                    minout.Text = "0" + m.ToString();
                else
                    minout.Text = m.ToString();
                counter = 0;
                secout.Text = "0"+counter.ToString();
            }
            else
            {
                counter++;

                if (counter < 10)
                    secout.Text = "0" + counter.ToString();
                else
                    secout.Text = counter.ToString();

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(minout.Text +":" +secout.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = listBox1.SelectedIndex != -1;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

     
    }
}
