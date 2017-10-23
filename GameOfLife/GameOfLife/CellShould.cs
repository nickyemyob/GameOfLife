using NUnit.Framework;
using NUnit.Framework.Internal;

namespace GameOfLife
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

    }
}
