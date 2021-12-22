using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace Theme
{
    internal class Persistance<T>
    {
        private List<T> _list=new List<T>();
        public void Save(T element)
        {
            _list.Add(element);
        }
        public List<T> Load()
        {
            return _list;
        }
    }
}
