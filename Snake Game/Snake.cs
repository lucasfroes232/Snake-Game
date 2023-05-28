using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    internal class Snake
    {
        public int tamanho { get; private set; }// tamanho da cobra 
        public Point[] location { get; private set; }//fila de pontos(x,y)na tela que corresponde a cobra

        public Snake()
        {
            location = new Point[28 * 28];//tamanho maximo do vetor "maximo da cobra"
            rst();
        }
        public void rst()
        {
            tamanho = 7; // tamanho inicial da cobra
            for (int i = 0; i < tamanho; i++)
            {
                location[i].X = 12;
                location[i].Y = 12; 
            }
        }
        public void follow() {
            for (int i = tamanho - 1; i > 0; i--)
            {
                location[i] = location[i - 1];//corpo acompanha a cabeça
            }
        }
        public void up() {
            follow();
            location[0].Y--;
            if (location[0].Y < 0)
            {
                location[0].Y += 28;
            }
        }
        public void down() {
            follow();
            location[0].Y++;
            if (location[0].Y > 27)
            {
                location[0].Y -= 28;
            }
        }
        public void left() { 
        follow() ;
        location[0].X--;
            if (location[0].X < 0)
            {
                location[0].X += 28;
            }
        }
        public void right() {
            follow();
            location[0].X++;
            if (location[0].X > 27)
            {
                location[0].X -= 28;
            }
        }
        public void eatNormalApple() {
            this.tamanho = this.tamanho+1;
        }
        public void eatEnchangedApple()
        {
            this.tamanho = this.tamanho-1;
        }

    }
}
       
