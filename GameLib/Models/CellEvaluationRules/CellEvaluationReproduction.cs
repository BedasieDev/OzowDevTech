using GameLib.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GameLib.Models.CellEvaluationRules
{
    public class CellEvaluationReproduction : ICellEvaluationRule
    {
        public bool CellIsAlive => true;

        public bool EvaluateRule(Cell cell, List<Cell> neighbours)
        {
            return neighbours.Where(n => n.IsAlive).Count() == 3;
        }
    }
}