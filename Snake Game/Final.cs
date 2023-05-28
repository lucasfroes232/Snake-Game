using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Final : Form
    {
        private Label lb;
        public Final()
        {
            InitializeComponent();
        }
        public Final( string pontos)
        {
            InitializeComponent();
            lbFinalScore.Text= pontos;
        }

        private void endGame_Click(object sender, EventArgs e)
        {}

        private void lbFinalScore_Click(object sender, EventArgs e)
        { }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            voltar();
        }
        private void voltar()
        {
            Application.Restart();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
