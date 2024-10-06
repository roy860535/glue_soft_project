using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glue_soft_project
{
    public class DisplayTime
    {
        private List<IValueObserver<string>> _Observers = new List<IValueObserver<string>>();
        public CancellationTokenSource? _DisplayTimects = null;

        //觀察者主體
        public void AddObserver(IValueObserver<string> observer)
        {
            _Observers.Add(observer);
        }

        public void NotifyObservers(string time)
        {
            foreach(var observer in _Observers)
            {
                observer.OnValueChanged(time);
            }
        }

        //DisplayTime方法
        public void DisplayTimeTask()
        {
            if (_DisplayTimects == null)
            {
                _DisplayTimects = new CancellationTokenSource();
                UpdateDisplayTime(_DisplayTimects.Token);
            }
            else
            {
                CancelDisplayTime();
            }
        }

        public void UpdateDisplayTime(CancellationToken token)
        {
            Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    string currentTime = DateTime.Now.ToString(@"yyyy/MM/dd HH:mm:ss");
                    NotifyObservers(currentTime);
                    DateTime now = DateTime.Now;
                    int msUntilNextSecond = 1000 - now.Millisecond;
                    await Task.Delay(msUntilNextSecond, token);
                }
            });
        }

        public void CancelDisplayTime()
        {
            _DisplayTimects?.Cancel();
            _DisplayTimects = null;
        }

        public void ResetDisplayTime()
        {
            string currentTime = @"yyyy/MM/dd HH:mm:ss";
            NotifyObservers(currentTime);
        }
    }
}
