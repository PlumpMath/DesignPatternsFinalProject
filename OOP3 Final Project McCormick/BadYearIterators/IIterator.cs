using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadYearIterators
{
    public interface IIterator
    {
        /// <summary>
        /// Resets the collection
        /// </summary>
        void First();

        /// <summary>
        /// Gets the next item in the collection
        /// </summary>
        /// <returns>The next item in the list</returns>
        string Next();

        /// <summary>
        /// Checks to see if last item in the collection
        /// </summary>
        /// <returns></returns>
        bool IsDone();

        /// <summary>
        ///  Gets current item in the collection
        /// </summary>
        /// <returns></returns>
        string CurrentItem();
    }
}
