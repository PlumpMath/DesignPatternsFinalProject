using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BadYearIterators;

namespace BadYear
{
    public class Year1942 : Year, IHorribleYear
    {
        public Year1942()
        {
            this.horribleTruths = new List<string>()
            {
                "On February 2, FDR signs an excutive order directing the internment of Japanese-Americans and the seizure of their property.",
                "Film actress Carole Lombard and her mother are among all 22 aboard TWA Flight 3 killed when the Douglas DC-3 plane crashes into Potosi Mountain near Las Vegas in Nevada while she is returning from a tour to promote the sale of war bonds.",
                "On November 28, in Boston, Massachusetts, a fire in the Cocoanut Grove night club kills 491 people.",
                "In March, construction begins on the Badger Army Ammunition Plant near Baraboo, Wisconsin (the largest in the United States during WWII).",
                "June 4-7, Battle of Midway: The United States Navy defeats an Imperial Japanese Navy attack against Midway Atoll. More than 3,000 Japanese soldiers and 300 allied soldiers are killed during the attack."
            };
        }

        public void Add(string fact)
        {
            this.horribleTruths.Add(fact);
        }

        public IIterator CreateIterator()
        {
            return new Year1942Iterator(this.horribleTruths);
        }

        public override string ToString()
        {
            return "1942";
        }
    }
}
