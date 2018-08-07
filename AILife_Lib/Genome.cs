using System.Linq;

namespace AILife_Lib
{
    public class Genome
    {
        int[] genome = new int[64];
        
        public int MutateCount { get; private set; }

        public int[] Array => genome;

        public Command CommandAt(int point)
        {
            var id = genome[point];
            switch (id)
            {
                default: return Command.NoCommand;
            }
        }

        public void Mutate(int atPoint)
        {

        }

        public void Inverse(int atPoint)
        {

        }

        public void Crossover(int atPoint, Genome other)
        {

        }
    }
}