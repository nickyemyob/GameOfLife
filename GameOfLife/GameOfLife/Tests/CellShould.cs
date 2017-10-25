using System.Collections.Generic;
using GameOfLife.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using CollectionAssert = NUnit.Framework.CollectionAssert;

namespace GameOfLife.Tests
{
    [TestFixture]
    class CellShould
    {
        [Test]
        public void ReturnIsUnderPopulatedAsTrue_WhenThereIsOneNeighbour()
        {
            var cell = new Cell();
            const int liveNeighbours = 1;
            var isUnderPopulated = cell.IsUnderPopulated(liveNeighbours);
            Assert.AreEqual(true, isUnderPopulated);
        }

        [Test]
        public void ReturnIsUnderPopulatedAsFalse_WhenThereIsTwoNeighbours()
        {
            var cell = new Cell();
            const int liveNeighbours = 2;
            var isUnderPopulated = cell.IsUnderPopulated(liveNeighbours);
            Assert.AreEqual(false, isUnderPopulated);
        }

        [Test]
        public void ReturnIsOverPopulatedAsTrue_WhenThereIsFourNeighbours()
        {
            var cell = new Cell();
            const int liveNeighbours = 4;
            var isOverPopulated = cell.IsOverPopulated(liveNeighbours);
            Assert.AreEqual(true, isOverPopulated);
        }

        [Test]
        public void ReturnIsOverPopulatedAsFalse_WhenThereIsThreeNeighbours()
        {
            var cell = new Cell();
            const int liveNeighbours = 3;
            var isOverPopulated = cell.IsOverPopulated(liveNeighbours);
            Assert.AreEqual(false, isOverPopulated);
        }

        [Test]
        public void ReturnCanReproduceAsTrue_WhenThereIsThreeNeighbours()
        {
            var cell = new Cell();
            const int liveNeighbours = 3;
            var canReproduce = cell.CanReproduce(liveNeighbours);
            Assert.AreEqual(true, canReproduce);
        }

        [Test]
        public void ReturnTheNumberOfAliveNeighbours()
        {
            var cell = new Cell();
            var aliveCell = new Cell()
            {
                State = true
            };

            var deadCell = new Cell()
            {
                State = false
            };

            var neighbours = new List<Cell>
            {
                aliveCell,
                aliveCell,
                aliveCell,
                aliveCell,
                deadCell,
                deadCell,
                deadCell,
                deadCell
            };

            var numberOfAliveNeighbours = cell.GetAliveNeighbourCount(neighbours);
            var expected = 4;
            
            Assert.AreEqual(expected, numberOfAliveNeighbours);
        }

        [Test]
        public void ReturnAListOfTheCellsNeighbours()
        {          
            var universe = new Universe();

            var world = universe.CreateEmptyWorld(4,4);

            var neighbourFetcher = new NeighbourFetcher();
            Cell cell = new Cell()
            {
                X = 1,
                Y = 1

            };
            var neighbours = neighbourFetcher.GetAllNeighbours(world, cell);

            var deadCell = new Cell()
            {
                State = false
            };

            var expected = new List<Cell>();
            for (var i = 0; i < 8; i++)
            {
                expected.Add(deadCell);
            }

            CollectionAssert.AreEqual(expected, neighbours);

        }





    }
}
