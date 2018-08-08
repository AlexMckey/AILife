using System;
using System.Collections.Generic;
using System.Text;

namespace AILife_Lib
{
    public abstract class Cell
    {
        public static World World;

        public int Mineral { get; internal set; }
        public BotColor Color { get; internal set; }
        public CellState State { get; internal set; }
        public int X { get; internal set; }
        public int Y { get; internal set; }

        public virtual void Move() { }

        internal static Cell freeCell;
        public static Cell Free
        {
            get
            {
                if (freeCell == null) freeCell = new Free();
                return freeCell;
            }
        }

        internal static Cell wallCell;
        public static Cell Wall
        {
            get
            {
                if (wallCell == null) wallCell = new Wall();
                return wallCell;
            }
        }
    }

    public class Free : Cell
    {
        public Free() => State = CellState.Empty;

        public override string ToString() => " ";
    }

    public class Wall : Cell
    {
        public Wall() => State = CellState.Wall;

        public override string ToString() => "=";
    }

    public class Organic : Cell
    {
        public Organic(CellState state) => State = state;

        public override string ToString() => "#";

        public override void Move()
        {
            base.Move();
            if (State == CellState.FallingOrganic)
            {
                if (World.cells[Y + 1, X].State == CellState.Empty)
                {
                    World.cells[Y + 1, X] = this;
                    World.cells[Y, X] = Cell.Free;
                    Y++;
                }
                else World.cells[Y, X].State = CellState.Organic;
            }
        }
    }
}
