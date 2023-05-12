using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;
using System.Diagnostics;
using System.Threading;


namespace fartware
{
    public partial class Form1 : Form
    {
        SoundPlayer fart;
        bool fartplay = false;
        SoundPlayer toilet;
        bool toiletplay = false;
        SoundPlayer poop;
        bool poopplay = false;

        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            fart = new SoundPlayer(@"noise.wav");
            fart.PlayLooping();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void srtbtn(object sender, EventArgs e)
        {

        }

        private void stpbtn(object sender, EventArgs e)
        {

        }

        private void mxb(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            fart.Stop();
            toilet = new SoundPlayer(@"toiletdlc.wav");
            toilet.PlayLooping();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            fart.Stop();
            poop = new SoundPlayer(@"plop.wav");
            poop.PlayLooping();

        }
    

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();
        }
    }

}
