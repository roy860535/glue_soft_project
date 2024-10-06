using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glue_soft_project
{
    public class Counter
    {
        private CancellationTokenSource? _countToTenCts = null;
        public int CountToTenValue = 0;
        private Task? _CurrentCountToTenTask;
        private Label _label;

        public Counter(Label label)
        {
            _label = label;
        }

        public async void CountToTenTask()
        {
            if (_CurrentCountToTenTask == null || _CurrentCountToTenTask.IsCompleted)
            {
                _countToTenCts = new CancellationTokenSource();
                _CurrentCountToTenTask = UpdateCountToTen(_label, _countToTenCts);
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

        public void ResetCountToTen()
        {
            CountToTenValue = 0;
            _countToTenCts?.Cancel();
            _countToTenCts = null;
            UpdateLabel(_label, CountToTenValue.ToString());
        }

        private void UpdateLabel(Label label, string text)
        {
            string displayText = text ?? CountToTenValue.ToString();
            _label.Invoke((Action)(() =>
            {
                _label.Text = displayText;
            }));
        }
    }
}
