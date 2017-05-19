using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Svetofor
{
    public class Ellipse
    {
        public int x;
        public int y;
        public int width;
        public Color color;
        

        public Ellipse(int _x, int _y, int _width, Color _color)
        {
            x = _x;
            y = _y;
            width = _width;
            color = _color;
        }

        public void Draw(Graphics g)
        {
            g.FillEllipse(new Pen(color).Brush, x, y, width, width);
        }
        public void Drow(Graphics g)
        {
            g.DrawEllipse(new Pen(color,2), x, y, width, width);
        }
    }
}
