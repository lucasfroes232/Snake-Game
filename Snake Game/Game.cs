using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    internal class Game
    {
        //variaveis
        public Keys direcao { get; set; }
        public Keys arrows { get; set; }
        private Timer frame { get; set; }
        private Label lbPont { get; set; }
        private Panel PnTela { get; set; }
        private Jogo jg { get; set; }
        
        private int pontuacao = 0;
        private Food Apple;
        private Food EnchangedApple;
        private Snake cobra;
        private Bitmap offScreen;
        private Graphics graph;
        private Graphics screenGraph;
        //metodos
        public Game(ref Timer time,ref Label label,ref Panel panel) {
            frame= time;
            PnTela = panel;
            lbPont = label;
            offScreen = new Bitmap(428, 428);
            cobra = new Snake();
            Apple = new Food();
            EnchangedApple= new Food();
            direcao= Keys.Right;
            arrows = direcao;
        }//ligar os termos graficos e iniciar os obj
        public void start()
        {
            cobra.rst();
            Apple.createFood();
            direcao = Keys.Right;
            graph = Graphics.FromImage(offScreen);
            screenGraph = PnTela.CreateGraphics();
            frame.Enabled= true;
        }//rst cobra,cria maça,cria as telas
        public void clk() {
             if( ((arrows==Keys.Left)) && ((direcao!=Keys.Right)) ||
                 ((arrows==Keys.Right)) && ((direcao!=Keys.Left)) ||
                 ((arrows==Keys.Up)) && ((direcao!=Keys.Down))    ||
                 ((arrows==Keys.Down)) && ((direcao != Keys.Up))  ){
                    direcao = arrows;
                }
             switch( direcao )
            {
                case Keys.Left:
                    cobra.left();
                    break;
                case Keys.Right:
                    cobra.right(); 
                    break;
                case Keys.Up:
                    cobra.up();
                    break;
                case Keys.Down:
                    cobra.down();   
                    break;
            }//mexer a cobra
            graph.Clear(Color.DarkSlateGray);
            graph.DrawImage(Properties.Resources.Food, (Apple.location.X * 15), (Apple.location.Y * 15), 15, 15);
            if (pontuacao%50==0 && pontuacao!=0) {
                graph.DrawImage(Properties.Resources.Enchanged, (EnchangedApple.location.X * 15), (EnchangedApple.location.Y * 15), 15, 15);
            }
            
           
            bool gameOver = false;
            for(int i = 0; i < cobra.tamanho; i++)
            {
                if (i == 0){ graph.DrawImage(Properties.Resources.Head, (cobra.location[0].X * 15), (cobra.location[0].Y * 15), 15, 15); }
                else { graph.DrawImage(Properties.Resources.Body, (cobra.location[i].X * 15), (cobra.location[i].Y * 15), 15, 15); }

                if (cobra.location[i] == cobra.location[0] && i > 0)
                {
                    gameOver = true;
                }
            }
            screenGraph.DrawImage(offScreen, 0, 0);
            checkEat();//ver se a cabeca da cobra colidiu com a comida

            if (gameOver) { GameOver();
                            }

        }//movimentar a cobra,checar se comeu,bateu,morreu...
        public void GameOver() {
            frame.Enabled = false;
            graph.Dispose();
            screenGraph.Dispose();
            



        }//ver se foi de terno
        public void checkEat() {
            if (cobra.location[0] == Apple.location)
            {
                cobra.eatNormalApple();
                pontuacao = pontuacao+ 10;
                if(pontuacao%50 == 0){
                    EnchangedApple.createFood();
                }
                else { Apple.createFood(); }
                lbPont.Text = "SCORE:" + pontuacao;
            }
            if (cobra.location[0] == EnchangedApple.location)
            {
                cobra.eatEnchangedApple();
                pontuacao = pontuacao+10 ;
                Apple.createFood();
                lbPont.Text = "SCORE:" + pontuacao;
            }
        
        }//ver se bateu na comida
    }
}
