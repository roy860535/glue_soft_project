using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glue_soft_project
{
    public interface IValueObserver<T>
    {
        void OnValueChanged(T value);
    }
}
