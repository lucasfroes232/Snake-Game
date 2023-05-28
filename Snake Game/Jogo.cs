using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Jogo : Form
    {
        Game game;
        public Jogo()
        {
            InitializeComponent();
            game = new Game(ref Frame,ref LbPontos,ref PnTela);
            game.start();
            
        }

        private void PnTela_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LbPontos_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iniciarJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.start();
        }

        private void Frame_Tick(object sender, EventArgs e)
        {
            game.clk();
            if (Frame.Enabled == false)
            {
               
                Final end = new Final(LbPontos.Text);
                end.ShowDialog();
  
            }
        }

        private void Clicado(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode ==Keys.Up || e.KeyCode== Keys.Down)
            {
                game.arrows = e.KeyCode;
            } 
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (Frame.Enabled)
            {
                Frame.Enabled = false;
            }
            else
            {
                Frame.Enabled = true;
            }
        }
        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main MenuPrincipal = new Main();
            MenuPrincipal.ShowDialog();
        }
    }
}
