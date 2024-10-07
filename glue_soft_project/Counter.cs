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
        public event Action<int>? CountUpdated;

        //Count實際方法
        public async void CountToTenTask()
        {

            if (_CurrentCountToTenTask == null || _CurrentCountToTenTask.IsCompleted)
            {
                _countToTenCts = new CancellationTokenSource();
                _CurrentCountToTenTask = UpdateCountToTen(_countToTenCts);
                await _CurrentCountToTenTask;
            }
            else
            {
                ResetCountToTen();
                MessageBox.Show("計數任務已經重置");
            }
        }

        private async Task UpdateCountToTen(CancellationTokenSource token)
        {
            while (CountToTenValue <= 10 && !token.IsCancellationRequested)
            {
                CountUpdated?.Invoke(CountToTenValue);
                await Task.Delay(1000);
                CountToTenValue++;
            }
            ResetCountToTen();
        }

        public void ResetCountToTen()
        {
            _countToTenCts?.Cancel();
            _countToTenCts = null;
            _CurrentCountToTenTask = null;
            CountToTenValue = 0;
            CountUpdated?.Invoke(CountToTenValue);
        }

    }
}
