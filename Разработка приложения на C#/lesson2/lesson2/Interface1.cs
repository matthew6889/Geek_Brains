using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    public interface Iindexable<T>
    {
        T this[int index] { get; set; }
    }
}
