using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;


using TK.game;


namespace TK
{
    public partial class Form1 : Form
    {
        public Game2 game2 = new Game2(GraphicsMode.Default);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game2.Parent = this;
            game2.Dock = DockStyle.Fill;
        }



    }
}
