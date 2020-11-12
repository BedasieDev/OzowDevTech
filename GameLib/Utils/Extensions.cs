using GameLib.Models;
using System.Collections.Generic;
using System.Linq;

namespace GameLib.Utils
{
    public static class Extensions
    {
        public static int Width(this List<Cell> cells)
        {
            return cells.Where(cell => cell.Location.Y == 0).Count();
        }

        public static int Height(this List<Cell> cells)
        {
            return cells.Where(cell => cell.Location.Y == 0).Count();
        }
    }
}