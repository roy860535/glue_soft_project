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
        
        private CancellationTokenSource? _DisplayTimects = null;
        private Counter _counter;


        public FormCentralMenu()
        {
            InitializeComponent();
            _counter = new Counter(CountToTenLabel);
        }

        private void HelloWorldBtn_Click(object sender, EventArgs e)
        {
            UpdateLabel(HelloWorldLabel, "Hello World!");
        }

        private void CountToTenBtn_Click(object sender, EventArgs e)
        {
            _counter.ResetCountToTen();

            _counter.CountToTenTask();
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
                _counter.ResetCountToTen();
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
