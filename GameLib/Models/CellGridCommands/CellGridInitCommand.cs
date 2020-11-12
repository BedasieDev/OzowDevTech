using GameLib.Models.CellStates;
using System;
using System.Collections.Generic;

namespace GameLib.Models.CellGridCommands
{
    public class CellGridInitCommand<T> : CellGridCommandBase
    {
        public Func<List<Cell>, T> OnComplete { get; set; }

        public T Invoke(int width, int height, CellGrid cellGrid)
        {
            return Execute(() =>
            {
                var cells = new List<Cell>();

                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        var cell = new Cell(x, y, cellGrid);
                        cell.CellEvaluationState = new CellStateEvaluated(cell);
                        cells.Add(cell);
                    }
                }

                return OnComplete(cells);
            });
        }
    }
}