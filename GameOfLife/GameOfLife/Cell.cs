using NUnit.Framework.Constraints;

namespace GameOfLife
{
    public class Cell
    {

        private readonly int _x;
        private readonly int _y;

        public Cell()
        {
            _x = 0;
            _y = 0;
        }


        


        public override bool Equals(object obj)
        {
            var item = obj as Cell;

            if (item == null)
            {
                return false;
            }
            
            return _x.Equals(item._x) && _y.Equals(item._y);
        }
    }
}