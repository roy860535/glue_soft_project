using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace glue_soft_project
{
    public partial class FormCentralMenu : Form
    {
        private Counter _counter = new Counter();
        private DisplayTime _displayTime = new DisplayTime();

        public FormCentralMenu()
        {
            InitializeComponent();
            _counter.CountUpdated += OnCounterUpdated;
            _displayTime.TimeUpdated += OnDisplayTimeUpdated;
        }

        private void HelloWorldBtn_Click(object sender, EventArgs e)
        {
            UpdateLabel(HelloWorldLabel, "Hello World!");
        }
        
        private void CountToTenBtn_Click(object sender, EventArgs e)
        {
            _counter.CountToTenTask();
        }

        private void DisplayTimeBtn_Click(object sender, EventArgs e)
        {
            _displayTime.DisplayTimeTask();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("請問需要重置嗎?", "確認重置", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _counter.ResetCountToTen();
                _displayTime.CancelDisplayTime();
                _displayTime.ResetDisplayTime();
                UpdateLabel(HelloWorldLabel, "None");
            }

        }

        //Function
        private void UpdateLabel(Label label, string text)
        {
            this.Invoke((Action)(() =>
            {
                label.Text = text;
            }));
        }

        //觀察者實現
        public void OnCounterUpdated(int value)
        {
            string text = value.ToString();
            UpdateLabel(CountToTenLabel, text);
        }

        public void OnDisplayTimeUpdated(string time)
        {
            UpdateLabel(DisplayTimeLabel, time);
        }


        #region NotUsed

        private void HelloWorldLabel_Click(object sender, EventArgs e)
        {

        }

        private void DisplayTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void CountToTenLabel_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
