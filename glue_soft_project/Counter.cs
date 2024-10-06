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
        public List<IValueObserver<int>> _observer = new List<IValueObserver<int>>();

        //觀察者模式的主體
        public void Addserver(IValueObserver<int> observer)
        {
            _observer.Add(observer);
        }

        private void NotifyObserver(int value)
        {
            foreach(var observer in _observer)
            {
                observer.OnValueChanged(value);
            }
        }

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
                MessageBox.Show("任務已取消");
            }
        }

        private async Task UpdateCountToTen(CancellationTokenSource token)
        {
            while (CountToTenValue <= 10 && !token.IsCancellationRequested)
            {
                NotifyObserver(CountToTenValue);
                await Task.Delay(1000);
                CountToTenValue++;
            }
        }

        public void ResetCountToTen()
        {
            CountToTenValue = 0;
            _countToTenCts?.Cancel();
            _countToTenCts = null;
            NotifyObserver(CountToTenValue);
        }

    }
}
