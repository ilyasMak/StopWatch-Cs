using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronométr
{
    public partial class Form1 : Form
    {
        int disMs = 0, s = 0, min = 0, h=0,cmpt=0;

        private void Start_Click(object sender, EventArgs e)
        {
            T.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            T.Stop();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            disMs = 0; s = 0; min = 0; h = 0; cmpt = 0;

        }

        private void Save_Click(object sender, EventArgs e)
        {
            cmpt++;
            list.Items.Add("Lap "+cmpt+" "+LB.Text);
        }

        string SdisMs = "000", Ss = "00", Smin = "00", Sh = "00";
        public Form1()
        {
            InitializeComponent();
           
        }

        private void T_Tick(object sender, EventArgs e)
        {
            disMs++;
            //-------------
            if (disMs == 100) { disMs = 0; s += 1; }
            if(s == 60) { s = 0; min += 1; }
            if (min == 60) { min = 0; h += 60; }
            //------------
            if (disMs < 10) SdisMs = "00" + disMs; 
            if(disMs>=10 ) SdisMs = "0" + disMs;
            if(s<10) Ss = "0" + s;
            if(s>=10) Ss = s.ToString();
            if (min < 10) Smin = "0" + min;
            if (min >= 10) Smin = min.ToString();
            if (h < 10) Sh = "0" + h;
            if (h >= 10) Sh = h.ToString();
            //-------------
            LB.Text = Sh + " : " + Smin + " : " + Ss + " : " + SdisMs;

        }
    }
}
