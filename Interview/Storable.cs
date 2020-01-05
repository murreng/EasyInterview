using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Storable<T>: IStoreable<T>
    {
        public T Id { get; set; }
    }
}
