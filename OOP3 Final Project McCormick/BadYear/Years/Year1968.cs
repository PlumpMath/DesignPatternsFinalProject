using BadYearIterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadYear
{
    public class Year1968 : Year, IHorribleYear
    {

        public Year1968()
        {
            this.horribleTruths = new List<string>()
            {
                "North Vietnam launches the Tet Offensive against the United States and South Vietnam. It signified the beginning of the end for U.S. involvement in Vietnam.",
                "On April 4, 1968, Martin Luther King Jr. was assasinated at a motel in Memphis.",
                "On June 5, 1968, Robert F. Kennedy was asssinated in Los Angeles",
                "At the Summer Olympics in Mexico City, sprinters Tommie Smith and John Carlos staged a silent demonstration against racial discrimination in the United States.",
                "December 24, U.S. spacecraft Apollo 8 enters orbit around the Moon. Astronauts Frank Borman, Jim Lovell and William A. Anders become the first humans to see the far side of the Moon and planet Earth as a whole.",
                "February 8, a civil rights protest staged at a white-only bowling alley in Orangeburg, South Carolina is broken up by highway patrolmen; 3 college students are killed.",
                "March 16, My Lai massacre: American troops kill scores of civilians. The story will first become public in November 1969 and will help undermine public support for the U.S. efforts in Vietnam.",
                "March 18, Congress repeals the requirement for a gold reserve to back U.S. currency.",
                "April 6, A shootout between Black Panthers and Oakland police results in several arrests and deaths, including 16-year-old Panther Bobby Hutton.",
                "October 14, The United States Department of Defense announces that the United States Army and United States Marines will send about 24,000 troops back to Vietnam for involuntary second tours.",
                "November 20, The Farmington Mine Disaster in Farmington, West Virginia, kills seventy-eight men.",
                "January 14, Green Bay Packers win Super Bowl II.",
                "March 11, President Lyndon B. Johnson mandates that all computers purchased by the federal government support the ASCII character encoding."
            };
        } 

        public void Add(string fact)
        {
            this.horribleTruths.Add(fact);
        }

        public IIterator CreateIterator()
        {
            return new Year1968Iterator(this.horribleTruths);
        }

        public override string ToString()
        {
            return "1968";
        }
    }
}
