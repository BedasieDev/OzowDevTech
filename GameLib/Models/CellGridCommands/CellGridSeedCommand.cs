using System;
using System.Collections.Generic;

namespace GameLib.Models.CellGridCommands
{
    public class CellGridSeedCommand<T> : CellGridCommandBase
    {
        public Func<List<Cell>, T> OnComplete { get; set; }

        public T Invoke(List<Cell> cells, Random rand)
        {
            return Execute(() =>
            {
                cells.ForEach(cell => cell.IsAlive = rand.Next(1, 100) % 3 == 0);
                return OnComplete(cells);
            });
        }
    }
}
