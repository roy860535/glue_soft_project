using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glue_soft_project
{
    public class DisplayTime
    {
        public event Action<string>? TimeUpdated;
        public CancellationTokenSource? _DisplayTimects = null;


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
                    TimeUpdated?.Invoke(currentTime);
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
            TimeUpdated?.Invoke(currentTime);
        }
    }
}
