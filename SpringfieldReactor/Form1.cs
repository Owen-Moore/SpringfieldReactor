using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace SpringfieldReactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

       


        private void enableButton_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.alert);
            player.Play();
            outputLabel.Text = "REACTOR MELTDOWN";
             
            reactor1StateLabel.BackColor = Color.Red;
                label4.BackColor = Color.Red;
                Refresh(); Thread.Sleep(500);
               
                reactor1StateLabel.BackColor = Color.White;
                label4.BackColor = Color.White;
                Refresh(); Thread.Sleep(500); 
            
            
        }

        

        private void resetButton1_Click(object sender, EventArgs e)
        {
            reactor1StateLabel.BackColor = Color.Chartreuse;
            label4.BackColor = Color.Chartreuse;
            outputLabel.Text = "reactor stable";
        }
    }
}
