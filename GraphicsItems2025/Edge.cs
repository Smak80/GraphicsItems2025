using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsItems2025
{
    public class Edge
    {
        private Random random = new Random();
        double _x1, _x2, _y1, _y2;
        public double X1 => _x1;
        public double Y1 => _y1;
        public double X2 => _x2;
        public double Y2 => _y2;
        public Edge()
        {
            _x1 = random.NextDouble() * 500;
            _x2 = random.NextDouble() * 500;

            _y1 = random.NextDouble() * 500;
            _y2 = random.NextDouble() * 500;
        }
    }
}
