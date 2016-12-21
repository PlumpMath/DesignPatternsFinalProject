using BadYearIterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadYear
{
    public interface IHorribleYear
    {
        void Add(string fact);

        IIterator CreateIterator();
    }
}
