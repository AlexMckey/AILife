namespace AILife_Lib
{
    public class Bot: Cell
    {
        protected Bot()
        {
            State = CellState.Bot;
        }
    }

    public class MultiBot : Cell
    {
        protected MultiBot()
        {
            State = CellState.MultiBot;
        }
    }
}
