using GameLib.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GameLib.Models.CellEvaluationRules
{
    public class CellEvaluationUnderpopulation : ICellEvaluationRule
    {
        public bool CellIsAlive => false;

        public bool EvaluateRule(Cell cell, List<Cell> neighbours)
        {
            return neighbours.Where(n => n.IsAlive).Count() < 2;
        }
    }
}