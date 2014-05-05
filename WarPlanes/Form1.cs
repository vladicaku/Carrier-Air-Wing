﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WarPlanes
{
    public partial class Form1 : Form
    {
        public Game game;
        public Timer timer;
        public static int FRAMES_PER_SECOND = 45;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            game = new Game();
            game.BoundsX = this.Width;
            game.BoundsY = this.Height;
            timer = new Timer();
            timer.Interval = 1000 / FRAMES_PER_SECOND;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
            game.Move();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.A)
                game.p1.plane.keys.ctrl = 1;
            if (e.KeyCode == System.Windows.Forms.Keys.Up)
            {
                game.p1.plane.keys.up = 1;
                game.p1.plane.keys.down = 0;
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.Down)
            {
                game.p1.plane.keys.down = 1;
                game.p1.plane.keys.up = 0;
            }
            if (e.KeyCode == System.Windows.Forms.Keys.Left)
            {
                game.p1.plane.keys.left = 1;
                game.p1.plane.keys.right = 0;
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.Right)
            {
                game.p1.plane.keys.right = 1;
                game.p1.plane.keys.left = 0;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.A)
            {
                game.p1.plane.keys.ctrl = 0;
            }
            if (e.KeyCode == System.Windows.Forms.Keys.Up)
                game.p1.plane.keys.up = 0;
            else if (e.KeyCode == System.Windows.Forms.Keys.Down)
                game.p1.plane.keys.down = 0;
            if (e.KeyCode == System.Windows.Forms.Keys.Left)
                game.p1.plane.keys.left = 0;
            else if (e.KeyCode == System.Windows.Forms.Keys.Right)
                game.p1.plane.keys.right = 0;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            game.Draw(g);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
