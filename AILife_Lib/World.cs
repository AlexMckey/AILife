using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AILife_Lib
{
    public class World
    {
        public readonly int weight;
        public readonly int heigth;
        public readonly int lightBorder;
        public int Generations;
        public Cell[,] cells;
        public ViewState View;

        //Быстрый способ преобразования двумерного массива в список (одномерный)
        //double[] tmp = new double[array.GetLength(0) * array.GetLength(1)];
        //Buffer.BlockCopy(array, 0, tmp, 0, tmp.Length* sizeof(double));
        //List<double> list = new List<double>(tmp);

        public List<Cell> NonFreeCells => cells.Cast<Cell>().Where(c => c.State != CellState.Free).ToList();
        public List<Cell> LivingCells => cells.Cast<Cell>().Where(c => c.State == CellState.Bot || c.State == CellState.MultiBot).ToList();

        public int NextState()
        {

            return Generations++;
        }

        public void InitAdam()
        {
            cells[heigth / 2, weight / 2] = Bot.Adam;
        }

        public World(int h, int w, double lightDeepOrigin = 0.5)
        {
            weight = w;
            heigth = h;
            lightBorder = (int) Math.Round(h * lightDeepOrigin);
            cells = new Cell[heigth, weight];
            for (var y = 0; y < heigth; y++)
                for (var x = 0; x < weight; x++)
                    cells[y, x] = new Free();
        }

        public override string ToString()
        {
            var sb = new StringBuilder((weight + 3) * (heigth + 2));
            sb.AppendLine(new String('-',weight+2));
            for (var y = 0; y < heigth; y++)
            {
                sb.Append("|");
                for (var x = 0; x < weight; x++)
                    sb.Append(cells[y, x].ToString());
                sb.AppendLine("|");
            }
            sb.AppendLine(new String('-', weight+2));
            return sb.ToString();
        }
    }
}
