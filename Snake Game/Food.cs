using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    internal class Food
    {
        public Point location { get; private set; }
        
        public void createFood()
        {
                Random rnd = new Random();
                location = new Point(rnd.Next(0, 27), rnd.Next(0, 27));
        }
    }
}
