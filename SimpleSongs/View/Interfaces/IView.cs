using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSongs.View.Interfaces
{
    public interface IView<T>
    {
        public void DisplayAll(List<T> entities);
        void DisplaySingle(T entity);
    }
}
