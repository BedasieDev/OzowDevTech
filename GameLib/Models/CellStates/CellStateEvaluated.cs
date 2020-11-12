using GameLib.Interfaces;

namespace GameLib.Models.CellStates
{
    public class CellStateEvaluated : ICellState
    {
        public Cell Cell { get; set; }

        public CellStateEvaluated(Cell cell)
        {
            Cell = cell;
        }
        public void OnCellStateEnter() { }
        public void OnCellStateExit() { }
    }
}
