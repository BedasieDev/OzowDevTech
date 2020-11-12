using System.Linq;
using System.Numerics;
using GameLib.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameTests
{
    [TestClass]
    public class SanityTests
    {

        private const int width = 5;
        private const int height = 5;

        [TestMethod]
        public void TestCellGridInit()
        {
            var cellGrid = new CellGrid(width, height);

            Assert.AreEqual(width * height, cellGrid.Cells.Count);
            Assert.IsFalse(cellGrid.Cells.All(cell => cell.IsAlive));
            Assert.IsFalse(cellGrid.Cells.All(cell => !cell.IsAlive));
            Assert.AreEqual(width - 1, cellGrid.Cells.Max(cell => cell.Location.X));
            Assert.AreEqual(height - 1, cellGrid.Cells.Max(cell => cell.Location.Y));
        }

        [TestMethod]
        public void TestCellGetNeighbours()
        {
            var cellGrid = new CellGrid(width, height);

            var target = new Vector2(2, 2);
            var n1 = new Vector2(1, 1);
            var n2 = new Vector2(2, 3);
            var n3 = new Vector2(3, 2);

            var neighbours = cellGrid.Cells.FirstOrDefault(cell => cell.Location == target).GetNeighbours();

            Assert.IsTrue(neighbours.Exists(n => n.Location == n1));
            Assert.IsTrue(neighbours.Exists(n => n.Location == n2));
            Assert.IsTrue(neighbours.Exists(n => n.Location == n3));
        }
    }
}