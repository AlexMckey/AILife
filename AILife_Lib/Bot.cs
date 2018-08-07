namespace AILife_Lib
{
    public abstract class LivingCell : Cell
    {
        public int CmdAddr { get; private set; }
        public int Health { get; set; }
        public Directions Directions { get; set; } = Directions.Stay;
        public Genome Genome { get; set; }

        public override void Move()
        {
            var cycle = 0;
            var moveEnd = false;
            do
            {
                var cmd = Genome.CommandAt(CmdAddr);

                if (cycle++ >= 15) moveEnd = true;
            } while (moveEnd);
        }
    }

    public class Bot: LivingCell
    {
        public static Cell Adam(World world)
        {
            var res = new Bot();
            return res;
        }

        public Bot() => State = CellState.Bot;

        public override string ToString() => "*";
    }

    public class MultiBot : LivingCell
    {
        public MultiBot() => State = CellState.MultiBot;

        public override string ToString() => "O";
    }
}
