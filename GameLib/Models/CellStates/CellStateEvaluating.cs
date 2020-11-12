using GameLib.Interfaces;
using GameLib.Models.CellEvaluationRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Models.CellStates
{
    public class CellStateEvaluating : ICellState
    {
        public Cell Cell { get; set; }
        private List<ICellEvaluationRule> cellEvaluationRules;


        public CellStateEvaluating(Cell cell)
        {
            Cell = cell;
            cellEvaluationRules = new List<ICellEvaluationRule>()
            {
                new CellEvaluationNextGeneration(),
                new CellEvaluationReproduction(),
                new CellEvaluationOverpopulation(),
                new CellEvaluationUnderpopulation()
            };
        }

        public void OnCellStateEnter()
        {
            Evaluate();
        }

        public void OnCellStateExit()
        {

        }

        private void Evaluate()
        {
            var neighbours = Cell.GetNeighbours();

            foreach (var rule in cellEvaluationRules)
                if (rule.EvaluateRule(Cell, neighbours))
                {
                    Cell.IsAliveInTheNextGeneration = rule.CellIsAlive;
                    break;
                }

            Cell.CellEvaluationState = new CellStateEvaluated(Cell);
        }
    }
}