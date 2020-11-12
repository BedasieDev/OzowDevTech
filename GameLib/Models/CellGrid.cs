using GameLib.Models.CellGridCommands;
using GameLib.Models.CellStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLib.Models
{
    public class CellGrid
    {
        public List<Cell> Cells { get; set; }
        private Random rand;

        public CellGrid(int width, int height)
        {
            rand = new Random();
            InitGrid(width, height);
        }

        private void InitGrid(int width, int height)
        {
            InitGridCells(width, height);
            SeedGridCells(rand);
        }

        public string GetGenerationOutput()
        {
            var sb = new StringBuilder();
            var currentRow = 0;

            foreach (var cell in Cells.OrderBy(cell => cell.Location.X).ThenBy(cell=> cell.Location.Y))
            {
                currentRow = CheckIfOnNewRow(sb, currentRow, cell);
                sb.Append(cell.Output);
            }

            return sb.ToString();
        }

        public void EvaluateCells()
        {
            foreach (var cell in Cells.OrderBy(cell => cell.Location.X).ThenBy(cell => cell.Location.Y))
                cell.CellEvaluationState = new CellStateEvaluating(cell);

            foreach (var cell in Cells)
                cell.IsAlive = cell.IsAliveInTheNextGeneration;
        }

        #region Private Functions
        private void SeedGridCells(Random rand)
        {
            Cells = new CellGridSeedCommand<List<Cell>>
            {
                OnComplete = Cells => Cells
            }.Invoke(Cells, rand);
        }

        private void InitGridCells(int width, int height)
        {
            Cells = new CellGridInitCommand<List<Cell>>
            {
                OnComplete = Cells => Cells
            }.Invoke(width, height, this);
        }

        private int CheckIfOnNewRow(StringBuilder sb, int currentRow, Cell cell)
        {
            if (cell.Location.X != currentRow)
            {
                currentRow = (int)cell.Location.X;
                sb.AppendLine();
            }

            return currentRow;
        } 
        #endregion
    }
}