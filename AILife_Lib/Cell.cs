using System;
using System.Collections.Generic;
using System.Text;

namespace AILife_Lib
{
    public abstract class Cell
    {
        public int CmdAddr { get; private set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Health { get; set; }
        public int Mineral { get; set; }
        public BotColor Color { get; set; }
        public Directions Directions { get; set; }
        public CellState State { get; set; }
    }

    public class Free : Cell
    {
        protected Free()
        {
            State = CellState.Free;
        }
    }

    public class Organic : Cell
    {
        protected Organic()
        {
            State = CellState.Organic;
        }
    }

    public class FallOrganic : Organic
    {
        protected FallOrganic()
        {
            State = CellState.FallingOrganic;
        }
    }
}
