using GameLib.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GameLib.Models.CellEvaluationRules
{
    public class CellEvaluationNextGeneration : ICellEvaluationRule
    {
        public bool CellIsAlive => true;

        public bool EvaluateRule(Cell cell, List<Cell> neighbours)
        {
            return new int[] { 2, 3 }.Contains(neighbours.Where(n => n.IsAlive).Count());
        }
    }
}