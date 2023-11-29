using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    public class NewByte: IBitGetable
    {
        public bool GetBitByIndex(byte index)
        {
            throw new NotFiniteNumberException ();
        }
        public void SetBitByIndex(byte index, bool value)
        { 
            throw new NotFiniteNumberException ();
        }

    }
}
