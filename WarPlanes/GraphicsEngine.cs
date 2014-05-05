﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using WarPlanes.Properties;

namespace WarPlanes
{
    public class GraphicsEngine
    {
        //public static Bitmap planeSprites = new Bitmap(Resources.UNSquadronPlayer);
        public static Bitmap[][] planeSprites = new Bitmap[3][];
        public static Bitmap[][] rocketSprites = new Bitmap[3][];

        public static void Init()
        {
            //F-14 Tomcat
            planeSprites[0] = new Bitmap[3];
            Bitmap bmp = new Bitmap(Resources.UNSquadronPlayer);
            Bitmap croped = bmp.Clone(new Rectangle(8, 250, 50, 15), bmp.PixelFormat);
            Bitmap scaled = new Bitmap(croped, (int)(croped.Width * 1.5), (int)(croped.Height * 1.5));
            planeSprites[0][0] = scaled;
            croped = bmp.Clone(new Rectangle(295, 270, 48, 17), bmp.PixelFormat);
            scaled = new Bitmap(croped, (int)(croped.Width * 1.5), (int)(croped.Height * 1.5));
            planeSprites[0][1] = scaled;
            croped = bmp.Clone(new Rectangle(125, 295, 47, 18), bmp.PixelFormat);
            scaled = new Bitmap(croped, (int)(croped.Width * 1.5), (int)(croped.Height * 1.5));
            planeSprites[0][2] = scaled;

            //A-10 ThuderBolt
            planeSprites[1] = new Bitmap[3];
            croped = bmp.Clone(new Rectangle(6, 526, 50, 15), bmp.PixelFormat);
            scaled = new Bitmap(croped, (int)(croped.Width * 1.5), (int)(croped.Height * 1.5));
            planeSprites[1][0] = scaled;
            croped = bmp.Clone(new Rectangle(308, 548, 48, 17), bmp.PixelFormat);
            scaled = new Bitmap(croped, (int)(croped.Width * 1.5), (int)(croped.Height * 1.5));
            planeSprites[1][1] = scaled;
            croped = bmp.Clone(new Rectangle(70, 587, 45, 23), bmp.PixelFormat);
            scaled = new Bitmap(croped, (int)(croped.Width * 1.5), (int)(croped.Height * 1.5));
            planeSprites[1][2] = scaled;

            bmp.Dispose();

            //Rockets
            rocketSprites[0] = new Bitmap[2];
            bmp = new Bitmap(Resources.rocket0);
            croped = new Bitmap(bmp, (int)(bmp.Width * 0.2F), (int)(bmp.Height * 0.2F));
            rocketSprites[0][0] = croped;

            bmp = new Bitmap(Resources.rocket1);
            croped = new Bitmap(bmp, (int)(bmp.Width * 0.2F), (int)(bmp.Height * 0.2F));
            rocketSprites[0][1] = croped;

            rocketSprites[1] = new Bitmap[2];
            bmp = new Bitmap(Resources.rocket2);
            croped = new Bitmap(bmp, (int)(bmp.Width * 0.7F), (int)(bmp.Height * 0.7F));
            rocketSprites[1][0] = croped;

            bmp = new Bitmap(Resources.rocket3);
            croped = new Bitmap(bmp, (int)(bmp.Width * 0.7F), (int)(bmp.Height * 0.7F));
            rocketSprites[1][1] = croped;

            rocketSprites[2] = new Bitmap[2];
            bmp = new Bitmap(Resources.rocket4);
            croped = new Bitmap(bmp, (int)(bmp.Width * 1.5F), (int)(bmp.Height * 1.2F));
            rocketSprites[2][0] = croped;

            bmp = new Bitmap(Resources.rocket5);
            croped = new Bitmap(bmp, (int)(bmp.Width * 1.5F), (int)(bmp.Height * 1.2F));
            rocketSprites[2][1] = croped;

        }

    }
}
