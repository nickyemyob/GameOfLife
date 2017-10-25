using System.Collections.Generic;
using System.Linq;
using GameOfLife.Logic;
using NUnit.Framework;

namespace GameOfLife.Tests
{
    [TestFixture]
    public class UniverseShould
    {
        [Test]
        public void GenerateAWorldOnCreation()
        {
            var universe = new Universe();
            var expectedWorld = new List<List<Cell>>();
            for (var i = 0; i < 4; i++)
                expectedWorld.Add(Enumerable.Repeat(new Cell(), 4).ToList());
            var result = universe.CreateEmptyWorld(4,4);
            CollectionAssert.AreEqual(expectedWorld, result);
        }
    }
}