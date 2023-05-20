using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelegramBot
{
    public partial class PercentForm : Form
    {
        public double percent_value = 0;
        public int nAddedCount = 0;
        public bool bStop = false;

        public PercentForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            timer1.Enabled = true;           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string result = String.Format("{0:0.00}%", percent_value);
            progressBar1.Value = (int)(percent_value + 0.5);
            labelPercent.Text = result;
            progressBar1.Refresh();

            labelAddedCount.Text = nAddedCount.ToString();
            Application.DoEvents();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            bStop = true;
          //  this.Hide();
        }
    }
}
