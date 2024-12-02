namespace Activity1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Make a list
            List<Candidate> CandidateList = new List<Candidate>();


            Candidate P1 = new Candidate("Douglas","Jane","Oxbox", 12724);
            Candidate P2 = new Candidate("Rose", "Ellen", "Oxtra", 10214);
            Candidate P3 = new Candidate("Westaway", "Luke", "Oxtra", 9011);
            Candidate P4 = new Candidate("Farrant", "Andy", "Oxbox", 13319);
            Candidate P5 = new Candidate("Channel", "Mike", "Oxbox", 8953);
            Candidate P6 = new Candidate("Chiodini", "Johnny", "Oxventure", 10466);

            CandidateList.Add(P1);
            CandidateList.Add(P2);
            CandidateList.Add(P3);
            CandidateList.Add(P4);
            CandidateList.Add(P5);
            CandidateList.Add(P6);

            foreach (Candidate c in CandidateList)
            {
                Console.WriteLine(c.ToString());
            }

        }
    }
 }
