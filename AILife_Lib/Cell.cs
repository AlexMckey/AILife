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
        public Genome Genome { get; set; }
    }

    public class Free : Cell
    {
        public Free()
        {
            State = CellState.Free;
        }

        public override string ToString()
        {
            return " ";
        }
    }

    public class Organic : Cell
    {
        public Organic()
        {
            State = CellState.Organic;
        }

        public override string ToString()
        {
            return "#";
        }
    }

    public class FallOrganic : Organic
    {
        public FallOrganic()
        {
            State = CellState.FallingOrganic;
        }

        public override string ToString()
        {
            return "#";
        }
    }
}
