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
        private Task? _CurrentCountToTenTask;
        private CancellationTokenSource? _DisplayTimects = null;
        private CancellationTokenSource? _countToTenCts = null;
        public int CountToTenValue = 0; 


        public FormCentralMenu()
        {
            InitializeComponent();
        }

        private void HelloWorldBtn_Click(object sender, EventArgs e)
        {
            UpdateLabel(HelloWorldLabel, "Hello World!");
        }

        private void CountToTenBtn_Click(object sender, EventArgs e)
        {
            ResetCountToTen();

            if (_CurrentCountToTenTask != null && !_CurrentCountToTenTask.IsCompleted)
            {
                _countToTenCts?.Cancel();
            }

            CountToTenTask();
        }

        private void DisplayTimeBtn_Click(object sender, EventArgs e)
        {
            if (_DisplayTimects == null)
            {
                _DisplayTimects = new CancellationTokenSource();
                UpdateDisplayTime(DisplayTimeLabel, _DisplayTimects.Token);
            }
            else {
                CancelDisplayTime();
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("請問需要重置嗎?", "確認重置", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CancelDisplayTime();
                ResetCountToTen();
                UpdateLabel(HelloWorldLabel, "None");
                UpdateLabel(DisplayTimeLabel, "yyyy/MM/dd HH:mm:ss");
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

        //Count_To_Ten類別
        private async void CountToTenTask()
        {
            if (_CurrentCountToTenTask == null || _CurrentCountToTenTask.IsCompleted)
            {
                _countToTenCts = new CancellationTokenSource();
                _CurrentCountToTenTask = UpdateCountToTen(CountToTenLabel, _countToTenCts);
                await _CurrentCountToTenTask;
            }
            else
            {
                MessageBox.Show("任務已取消");
            }
        }

        private async Task UpdateCountToTen(Label label, CancellationTokenSource token)
        {
            while (CountToTenValue <= 10 && !token.IsCancellationRequested)
            {
                UpdateLabel(label, CountToTenValue.ToString());
                await Task.Delay(1000);
                CountToTenValue++;
            }
        }

        private void ResetCountToTen()
        {
            CountToTenValue = 0;
            _countToTenCts?.Cancel();
            UpdateLabel(CountToTenLabel, CountToTenValue.ToString());
        }

        //Display_Time類別
        private void UpdateDisplayTime(Label label,CancellationToken token)
        {
            Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    this.Invoke((Action)(() =>
                    {
                        UpdateLabel(label, DateTime.Now.ToString(@"yyyy/MM/dd HH:mm:ss"));
                    }));
                    DateTime now = DateTime.Now;
                    int msUntilNextSecond = 1000 - now.Millisecond;
                    await Task.Delay(msUntilNextSecond, token);
                }
            });
        }

        private void CancelDisplayTime()
        {
            _DisplayTimects?.Cancel();
            _DisplayTimects = null;
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
