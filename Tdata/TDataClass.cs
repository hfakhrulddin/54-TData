using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdata
{
    class TDataClass<TData>: IEnumerable<TData>
    {
        public IEnumerator<TData> GetEnumerator()
        {
            return null;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}
