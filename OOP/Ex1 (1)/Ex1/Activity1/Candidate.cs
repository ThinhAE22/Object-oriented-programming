namespace Activity1
{
    public class Candidate
    {
        // attributes == class variables
        private int _votes;

        // manually created Property
        public int Votes
        {
            get { return _votes; }
            private set
            {
                if (value >= 0)
                {
                    _votes = value;
                }
                else
                {
                    _votes = 0;
                }
            }
        }

        // auto-implemented properties
        public String FirstName { get; protected set; }
        public String LastName { get; protected set; }
        public String Party { get; protected set; }


        // methods

        // constructors
        public Candidate(string first, string last, string party)
        {
            FirstName = first;
            LastName = last;
            Party = party;
            Votes = 0;
        }

        public Candidate(string first, string last, string party, int votes)
        {
            FirstName = first;
            LastName = last;
            Party = party;
            Votes = votes;
        }
        // ToString method for getting the string
        // representation of the class, for example
        // for printing
        public override string ToString()
        {
            return $"{FirstName}, {LastName} ({Party}): {Votes}";
        }
    }
}
