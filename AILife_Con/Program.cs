using System;
using AILife_Lib;

namespace AILife_Con
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from BioCyberLife!");
            var world = new World(10,10);
            world.InitAdam();
            Console.WriteLine(world);
            Console.WriteLine("Количество непустых ячеек: " + world.NonFreeCells.Count);
            Console.WriteLine("Количество органики: " + world.OrganicCells.Count);
            Console.WriteLine("Количество живых клеток: " + world.LivingCells.Count);
        }
    }
}
