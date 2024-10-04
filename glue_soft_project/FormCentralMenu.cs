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
using Timer = System.Windows.Forms.Timer;

namespace glue_soft_project
{
    public partial class FormCentralMenu : Form
    {
        private Task? _CurrentCountToTenTask;
        private CancellationTokenSource? _cts = null;
        public int CountToTenValue = 0;
        public bool CountToTenEnabled = false;

        public FormCentralMenu()
        {
            InitializeComponent();
        }

        private void HelloWorldBtn_Click(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = "Hello World!";
        }

        private void CountToTenBtn_Click(object sender, EventArgs e)
        {
            CountToTenValue = 0;

            if (_CurrentCountToTenTask != null && !_CurrentCountToTenTask.IsCompleted)
            {
                CountToTenEnabled = false;
            }

            CountToTenTask();
        }

        private void DisplayTimeBtn_Click(object sender, EventArgs e)
        {
            if(_cts == null)
            {
                _cts = new CancellationTokenSource();
                UpdatedisplayTime(DisplayTimeLabel, _cts.Token);
            }
            else{
                _cts?.Cancel();
                _cts = null;
            }

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("請問需要重置嗎?", "確認重置", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _cts?.Cancel();
                _cts = null;
                CountToTenValue = 0;
                CountToTenEnabled = false;
                CountToTenLabel.Text = CountToTenValue.ToString();
                HelloWorldLabel.Text = "None";
                DisplayTimeLabel.Text = "yyyy/MM/dd HH:mm:ss";
            }

        }

        //Function
        public async void CountToTenTask()
        {
            if (_CurrentCountToTenTask == null || _CurrentCountToTenTask.IsCompleted)
            {
                _CurrentCountToTenTask = UpdateCountToTen(CountToTenLabel);
                await _CurrentCountToTenTask;
            }
            else
            {
                CountToTenValue = 0;
                CountToTenLabel.Text = CountToTenValue.ToString();
                MessageBox.Show("任務已取消");
            }
        }

        public async Task UpdateCountToTen(Label label)
        {
            CountToTenEnabled = true;
            while (CountToTenValue<=10&&CountToTenEnabled)
            {
                label.Text = CountToTenValue.ToString();
                await Task.Delay(1000);
                CountToTenValue++;
            }
        }

        public void UpdatedisplayTime(Label label,CancellationToken token)
        {
            Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    this.Invoke((Action)(() =>
                    {
                        label.Text = DateTime.Now.ToString(@"yyyy/MM/dd HH:mm:ss");
                    }));
                    DateTime now = DateTime.Now;
                    int msUntilNextSecond = 1000 - now.Millisecond;
                    await Task.Delay(msUntilNextSecond, token);
                }
            });
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
