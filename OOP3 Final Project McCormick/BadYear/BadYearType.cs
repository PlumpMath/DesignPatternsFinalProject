using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadYear
{
    public static class BadYearType
    {
        public static IHorribleYear ChooseBadYear (YearEnum year)
        {
            switch (year)
            {
                case YearEnum.Year1942:
                    return new Year1942();
                case YearEnum.Year1968:
                    return new Year1968();
                case YearEnum.Year2016:
                    return new Year2016();
                default:
                    return null;                  
            }
        }
    }
}
