using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadYearIterators
{
    public class Year1942Iterator : IIterator
    {
        public List<string> facts;

        private int position;

        public Year1942Iterator(List<string> facts)
        {
            this.facts = facts;
            this.position = 0;
        }

        public string CurrentItem()
        {
            return this.facts.ElementAt(position);
        }

        public void First()
        {
            this.position = 0;
        }

        public bool IsDone()
        {
            return this.position >= this.facts.Count;
        }

        public string Next()
        {
            return this.facts.ElementAt(position++);
        }
    }
}
