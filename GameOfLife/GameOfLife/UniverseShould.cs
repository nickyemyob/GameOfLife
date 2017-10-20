using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace GameOfLife
{
    [TestFixture]
    public class UniverseShould
    {
        [Test]
        public void GenerateAWorldOnCreation()
        {
            var universe = new Universe();
            var expectedWorld = new List<List<Cell>>();
            for (var i = 0; i < 10; i++)
                expectedWorld.Add(Enumerable.Repeat(new Cell(), 10).ToList());
            var result = universe.CreateWorld();
            CollectionAssert.AreEqual(expectedWorld, result);
        }
    }
}