using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;



namespace Fractal_Growth
{
    class Particle
    {
        // Class defines one single particle 
        // Start position by random 

        public Point position;       // definition of position of particle
        private int[,] area;        // definition of allowed area for particle
        private bool stick;         // is position of particle next to some other solid? if yes -> true
        private Random rnd;         // random number for initializing position and random-walk 

        public Particle (Random rnd, int[,] area)
        {
            this.rnd = rnd;         // hand-over of instance of Random-class
            start(area);            // set-up starting position and hand-over of area

        }
        // Constructor, first overload: random start position within defined area  

        public void start (int[,] area)
        {
            this.area = area;           // hand-over of area
            this.position.X = rnd.Next(1, area.GetLength(0) - 1); // upper limit of x-dimension from area[,] 
            this.position.Y = rnd.Next(1, area.GetLength(1) - 1); // upper limit of y-dimension from area[,]
            this.stick = false;         
        } // Methode, first overload: Can also used for restart particle

        public void RandomWalk()
        {
            int direction;
            while (stick != true)
            {
                direction = rnd.Next(1, 5);
                switch (direction)
                {
                    case 1:
                        if (position.X < area.GetLength(0)-1)
                        {
                            position.X = position.X + 1;
                            if (area[position.X, position.Y] != 0)
                            {
                                stick = true;
                                position.X = position.X - 1;
                            }
                        }
                        else
                            position.X = 1;
                        break;
                    case 2:
                        if (position.X > 0)
                        {
                            position.X = position.X - 1;
                            if (area[position.X, position.Y] != 0)
                            {
                                stick = true;
                                position.X = position.X + 1;
                            }
                        }
                        else
                            position.X = area.GetLength(0)-1;
                        break;
                    case 3:
                        if (position.Y < area.GetLength(1)-1)
                        {
                            position.Y = position.Y + 1;
                            if (area[position.X, position.Y] != 0)
                            {
                                stick = true;
                                position.Y = position.Y - 1;
                            }
                        }  
                        else
                            position.Y = 1;
                        break;
                    case 4:
                        if (position.Y > 0)
                        {
                            position.Y = position.Y - 1;
                            if (area[position.X, position.Y] != 0)
                            {
                                stick = true;
                                position.Y = position.Y + 1;
                            }
                        }    
                        else
                            position.Y = area.GetLength(1)-1;
                        break;
                }
            }
            //return position;
        }// Methode, first overload: random walk of particle
    }
}
