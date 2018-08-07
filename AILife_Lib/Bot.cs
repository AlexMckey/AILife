namespace AILife_Lib
{
    public abstract class LivingCell : Cell
    {

    }

    public class Bot: LivingCell
    {
        public static Cell Adam 
        {
            get
            {
                var res = new Bot();
                return res;
            }
        }

        public Bot()
        {
            State = CellState.Bot;
        }

        public override string ToString()
        {
            return "*";
        }
    }

    public class MultiBot : LivingCell
    {
        public MultiBot()
        {
            State = CellState.MultiBot;
        }

        public override string ToString()
        {
            return "O";
        }
    }
}
