using GameLib.Models;
using System.Collections.Generic;

namespace GameLib.Interfaces
{
    public interface ICellEvaluationRule
    {
        bool EvaluateRule(Cell cell, List<Cell> neighbours);
        bool CellIsAlive { get; }
    }
}