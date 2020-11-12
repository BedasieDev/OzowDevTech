using GameLib.Interfaces;
using GameLib.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace GameLib.Models
{
    public class Cell
    {
        public ICellState CellEvaluationState
        {
            get => cellState;
            set
            {
                if (cellState != null)
                    cellState.OnCellStateExit();

                cellState = value;
                cellState.OnCellStateEnter();
            }
        }

        public Vector2 Location { get; set; }
        public bool IsAlive { get; set; }
        public bool IsAliveInTheNextGeneration { get; set; }
        public string Output => IsAlive ? "X" : ".";
        private CellGrid cellGrid;
        private ICellState cellState;

        public Cell(int x, int y, CellGrid cellGrid, bool isAlive = false)
        {
            Location = new Vector2(x, y);
            IsAlive = isAlive;
            this.cellGrid = cellGrid;
        }

        public List<Cell> GetNeighbours()
        {
            var neighbours = new List<Cell>();
            var width = cellGrid.Cells.Width();
            var height = cellGrid.Cells.Height();

            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    var locationX = Location.X + x;
                    var locationY = Location.Y + y;

                    if (CheckIfWithinBounds(width, height, locationX, locationY))
                    {
                        var potentialNeighbour = cellGrid.Cells.FirstOrDefault(cell => cell.Location == new Vector2(locationX, locationY));

                        if (potentialNeighbour != null && !potentialNeighbour.Equals(this))
                            neighbours.Add(potentialNeighbour);
                    }

                }
            }

            return neighbours;
        }

        private bool CheckIfWithinBounds(int width, int height, float locationX, float locationY)
        {
            return locationX >= 0 && locationX <= width && locationY >= 0 && locationY <= height;
        }
    }
}