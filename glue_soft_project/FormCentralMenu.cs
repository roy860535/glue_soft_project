using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace glue_soft_project
{
    public partial class FormCentralMenu : Form
    {
        
        Timer timer = new Timer();
        public int CountToTenValue1 = 0;
        public int CountToTenValue2 = 0;

        public FormCentralMenu()
        {
            InitializeComponent();
        }

        private void HelloWorldBtn_Click(object sender, EventArgs e)
        {
            HelloWorldLable.Text = "Hello World!";
        }

        private void CountToTenBtn_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == false)
            {
                timer.Interval = 1000;
                timer.Tick += new EventHandler(Timer_Tick);
                timer.Enabled = true;
            }
            
            if (CountToTenValue1 < 10)
            {
                CountToTenValue1++;
                CountToTenLable.Text = CountToTenValue1.ToString();
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (CountToTenValue2 < 10)
            {
                CountToTenValue2++;
                CountToTenLable2.Text = CountToTenValue2.ToString();
            }

        }

        private void DisplayTimeBtn_Click(object sender, EventArgs e)
        {
            DisplayTimeTimer.Enabled = true;
        }

        private void DisplayTimeTimer_Tick(object sender, EventArgs e)
        {
            DisplayTimeLable.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            if (ResetCheck.Checked == true)
            {
                DisplayTimeTimer.Enabled = false;
                timer.Enabled = false;
                timer.Tick -= new EventHandler(Timer_Tick);
                CountToTenValue1 =0;
                CountToTenValue2=0;
                CountToTenLable.Text = CountToTenValue1.ToString();
                CountToTenLable2.Text = CountToTenValue1.ToString();
                HelloWorldLable.Text = "None";
                DisplayTimeLable.Text = "yyyy/MM/dd HH:mm:ss";
            }
        }

        #region NotUsed
        private void HelloWorldLable_Click(object sender, EventArgs e)
        {

        }

        private void DisplayTimeLable_Click(object sender, EventArgs e)
        {

        }

        private void CountToTenLable_Click(object sender, EventArgs e)
        {

        }

        private void CountToTenLable2_Click(object sender, EventArgs e)
        {

        }
        private void ResetCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
