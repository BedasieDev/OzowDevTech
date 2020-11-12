using GameLib.Models;

namespace GameLib.Interfaces
{
    public interface ICellState
    {
        Cell Cell { get; set; }
        void OnCellStateEnter();
        void OnCellStateExit();
    }
}