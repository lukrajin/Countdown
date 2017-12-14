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
            if (start.Text == "Start")
            {
                if (stopwatch.Checked == true)
                {
                    
                    mode.Enabled = false;
                    start.Text = "Pause";
                    timer1 = new System.Windows.Forms.Timer();
                    stop.Enabled = true;
                    add.Enabled = true;
                    timer1.Tick += new EventHandler(timer1_Tick2);
                    timer1.Interval = 1000;
                    timer1.Start();
                }
                else
                {
                   
                    mode.Enabled = false;
                    start.Text = "Pause";
                    minin.Enabled = false;
                    secin.Enabled = false;

                    timer1 = new System.Windows.Forms.Timer();
                    counter = (int)secin.Value;
                    int m = (int)minin.Value;
                    if (m < 10)
                        minout.Text = "0" + m.ToString();
                    else
                        minout.Text = m.ToString();

                    stop.Enabled = true;
                    timer1.Tick += new EventHandler(timer1_Tick);
                    timer1.Interval = 1000;
                    timer1.Start();

                    if (secin.Value < 10)
                        secout.Text = "0" + counter.ToString();
                    else
                        secout.Text = counter.ToString();
                }
            }
            else if (start.Text == "Pause")
            {
                start.Text = "Continue";
               
                timer1.Stop();
            }
            else if (start.Text == "Continue")
            {
                start.Text = "Pause";
                add.Enabled = true;
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
                start.Text = "Start";
                minout.BackColor = Color.White;
                secout.BackColor = Color.White;
                timer1.Stop();
                minin.Enabled = true;
                secin.Enabled = true;
                stop.Enabled = false;
                start.Enabled = true;
                mode.Enabled = true;

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


                start.Text = "Start";
                start.Enabled = true;
                timer1.Stop();
                counter = 0;
                mode.Enabled = true;
                add.Enabled = false;

                stop.Enabled = false;
                minin.Enabled = true;
                secin.Enabled = true;
                minout.Text = "00";
                secout.Text = "00";
                minout.BackColor = Color.White;
                secout.BackColor = Color.White;



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (stopwatch.Checked == true)
            {
                minin.Visible = false;
                secin.Visible = false;
                times.Visible = true;
                add.Visible = true;
                delete.Visible = true;
                start.Enabled = true;
            }
            else
            {
                minin.Visible = true;
                secin.Visible = true;
                times.Visible = false;
                add.Visible =false;
                delete.Visible = false;
                secin_ValueChanged(sender, e);



            }
           
        }
        private void timer1_Tick2(object sender, EventArgs e)
        {
        
            if (int.Parse(minout.Text) == 999 && int.Parse(secout.Text) == 59)
            {

                minout.Text = "00";
                secout.Text = "00";
                start.Text = "Start";
                minout.BackColor = Color.White;
                secout.BackColor = Color.White;
                timer1.Stop();
                minin.Enabled = true;
                secin.Enabled = true;
                stop.Enabled = false;
                start.Enabled = true;
                mode.Enabled = true;
                add.Enabled = false;

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
           
            times.Items.Add((times.Items.Count+1) + ". "+minout.Text + ":" + secout.Text);

          
            add.Enabled = start.Text != "Continue";


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int index = times.SelectedIndex;
            times.Items.RemoveAt(index);
            for(int i = index; i < times.Items.Count; i++)
            {

                string s = times.Items[index].ToString();
                s=s.Substring(s.IndexOf(" ") + 1);
                times.Items.RemoveAt(index);
                s = (i+1) + ". " + s;
                times.Items.Add(s);
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            delete.Enabled = times.SelectedIndex != -1;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            times.Items.Clear();
            delete.Enabled = false;
        }

        private void secin_ValueChanged(object sender, EventArgs e)
        {
          
            start.Enabled = secin.Value != 0 || minin.Value != 0;

        }
    }
}
