using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BadYearIterators;

namespace BadYear
{
    public class Year2016 : Year, IHorribleYear
    {
        public Year2016 ()
        {
            this.horribleTruths = new List<string>()
            {
                "On June 12, 2016, Omar Mateen opened fire at the Pulse Night Club in Orlando. He killed 49 people and wounded 53 others before he was shot and killed by police. It was the deadliest mass shooting by a single shooter and the deadliest incident of violence against LGBTQ people.",
                "On July 6, 2016, Philando Castile was fatally shot by a police officer in St. Anthony, Minnesota after being pulled over. Castile informed the officer he had a gun and a license to open-carry. As Castile reached for his gun, the officer opened fire. The aftermath of the shooting was live-streamed by Castile's girlfriend and sparked protests.",
                "On November 8, 2016, Donald Trump was elected president without winning the popular vote.",
                "Lots of celebrities died. RIP David Bowie, Prince, Muhammed Ali, Gene Wilder, Jose Fernandez, Phife Dawg, Alan Rickman, Natalie Cole, Abe Vigoda, Garry Shandling, Patty Duke, Doris Roberts, David Gest, Anton Yelchin, Alexis Arquette, Arnold Palmer, Gwen Ifill, Janet Reno, Sharon Jones, and John Glenn.",
                "Supreme Court Justice Antonin Scalia died. Congressional Republicans block the nomination of Merrick Garland.",
                "On May 28, 2016, a three-year-old boy climbed into a gorilla enclosure at the Cincinnati Zoo and Botanical Garden and was grabbed and dragged by Harambe, a 17-year-old Western lowland gorilla. Fearing for the boy's life, a zoo worker shot and killed Harambe. The incident received international coverage.",
                "Following a referendum held in June 2016, in which 52% of votes were cast in favour of leaving the EU, the UK government intends to invoke Article 50 of the Treaty on European Union, the formal procedure for withdrawing, by the end of March 2017.",
                "Hillary Clinton's ongoing email controversy.",
                "On July 5, 2016, Alton Sterling, a 37-year-old black man, was shot several times at close range while held down on the ground by two white Baton Rouge Police Department officers in Baton Rouge, Louisiana.",
                "As of mid-2016, a widespread epidemic of Zika fever, caused by the Zika virus, was ongoing in the Americas, the Pacific and Southeast Asia. The outbreak began in early 2015 in Brazil, then spread to other parts of South and North America",
                "Golden State Warriors blew a 3-1 lead. Cleveland Cavaliers win the NBA finals. The first major championship Cleveland has won since 1964.",
                "North Dakota pipeline protests result in the Army Corps of Engineers announcing on December 4th that they would not grant an easement for the pipeline.",
                "Facebook's fake news problem continues to persist. As a result a man brings a rifle to Comet Ping Pong in North Carolina alleging that the pizza place harbors a child prostitution ring linked to Hillary Clinton.",
                "Colin Kapernick sits during the National Anthem to protest racial discrimination in the United States. His actions sparked ",
                "The Chicago Cubs won the world series. But in context of this year, that might be a sign of the apocolypse."
            };
        }

        public string Description
        {
            get
            {
                return "2016 was not considered a good year. The election was weird, etc. etc.";
            }
        }

        public List<string> HorribleFacts
        {
            get
            {
                return this.horribleTruths;
            }

            set
            {
                this.horribleTruths = value;
            }
        }

        public void Add(string fact)
        {
            this.horribleTruths.Add(fact);
        }

        public IIterator CreateIterator()
        {
            return new Year2016Iterator(this.horribleTruths);
        }

        public override string ToString()
        {
            return "2016";
        }
    }
}
