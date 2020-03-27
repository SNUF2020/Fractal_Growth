﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;

namespace Fractal_Growth
{
    class MainMethods
    {
        public Control OutPut_Window()
        {
            Form w1 = new Form();
            w1.Text = "Output Window";                          // Set the caption bar text of the form w1.   
            w1.MaximizeBox = false;                             // Set the MaximizeBox to false to remove the maximize box.
            w1.MinimizeBox = false;                             // Set the MinimizeBox to false to remove the minimize box.
            w1.StartPosition = FormStartPosition.CenterScreen;  // Set the start position of the form to the center of the screen.
            w1.AutoSize = false;
            w1.Size = new Size(500, 620);
            PictureBox Pict = new PictureBox()
            {
                Size = new Size(500, 620),
                Location = new Point(0, 0),
            };
            w1.Controls.Add(Pict);
            w1.Show();             // show form w1
            return Pict;
        }
        public void Create_QRCode(Control ctrl, string payload)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator(); // creating an instance of the QR-Code-Generator 
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            // generating bitmap e.g. for forms
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(2);
            PictureBox P = new PictureBox()
            {
                Size = new Size(120, 120),
                Location = new Point(63, 310),
            };
            ctrl.Controls.Add(P);
            P.Image = qrCodeImage;
        }
        public int[,] PlayGround(Graphics gr, int Size, RadioButton RadioButton_P, RadioButton RadioButton_W, RadioButton RadioButton_WP, RadioButton RadioButton_PPP)
        {
            Pen myPen = new Pen(Color.Black, 1);
            int[,] playground = new int[Size, Size]; // generation and initiation of area
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    playground[i, j] = 0;
            if (RadioButton_P.Checked)
            {
                Message(14, "Fractal Growth from Central Dot", gr, 20, 10);
                // draw box = playground
                gr.DrawRectangle(myPen, 20, 40, Size, Size);
                Message(10, "Starting Point: Center of Square", gr, 20, Size + 50);
                Message(10, "After every 20.000 points colour is changing", gr, 20, Size + 70);
                // Dot
                for (int i = 1; i < 6; i++)
                {
                    playground[Size/2, Size/2 + i] = 1;
                    playground[Size/2 + 5, Size/2 + i] = 1;
                    playground[Size/2 + i, Size/2] = 1;
                    playground[Size/2 + i, Size/2 + 5] = 1;
                }
            }
            else if (RadioButton_W.Checked)
            {
                Message(14, "Fractal Growth from Wall", gr, 20, 10);
                // draw box = playground
                gr.DrawRectangle(myPen, 20, 40, Size, Size);
                Message(10, "Starting Point: Wall of System", gr, 20, Size + 50);
                Message(10, "After every 20.000 points colour is changing", gr, 20, Size + 70);
                // Wall
                for (int i = 0; i < 400; i++)
                {
                    playground[0, i] = 1;
                    playground[Size-1, i] = 1;
                    playground[i, 0] = 1;
                    playground[i, Size-1] = 1;
                }
            }
            else if (RadioButton_WP.Checked)
            {
                Message(14, "Fractal Growth from Wall and Central Point", gr, 20, 10);
                // draw box = playground
                gr.DrawRectangle(myPen, 20, 40, Size, Size);
                Message(10, "Starting Point: Wall of System and Point in the Middle of Square", gr, 20, Size + 50);
                Message(10, "After every 20.000 points colour is changing", gr, 20, Size + 70);
                // Wall
                for (int i = 0; i < Size; i++)
                {
                    playground[0, i] = 1;
                    playground[Size - 1, i] = 1;
                    playground[i, 0] = 1;
                    playground[i, Size - 1] = 1;
                }
                // Dot
                for (int i = 0; i < 5; i++)
                {
                    playground[Size / 2, Size / 2 + i] = 1;
                    playground[Size / 2 + 5, Size / 2 + i] = 1;
                    playground[Size / 2 + i, Size / 2] = 1;
                    playground[Size / 2 + i, Size / 2 + 5] = 1;
                }
            }
            else if (RadioButton_PPP.Checked)
            {
                Message(14, "Fractal Growth from Three Pointe", gr, 20, 10);
                // draw box = playground
                gr.DrawRectangle(myPen, 20, 40, Size, Size);
                Message(10, "Starting Points: Three Points in the Middle of Square", gr, 20, Size + 50);
                Message(10, "After every 20.000 points colour is changing", gr, 20, Size + 70);
                // Dot top midle
                for (int i = 0; i < 5; i++)
                {
                    playground[Size / 2, Size / 4 + i] = 1;
                    playground[Size / 2 + 5, Size / 4 + i] = 1;
                    playground[Size / 2 + i, Size / 4] = 1;
                    playground[Size / 2 + i, Size / 4 + 5] = 1;
                }
                // Dot bottom left
                for (int i = 0; i < 5; i++)
                {
                    playground[Size / 4, Size / 4 * 3 + i] = 1;
                    playground[Size / 4 + 5, Size / 4 * 3 + i] = 1;
                    playground[Size / 4 + i, Size / 4 * 3] = 1;
                    playground[Size / 4 + i, Size / 4 * 3 + 5] = 1;
                }
                // Dot bottom right
                for (int i = 0; i < 5; i++)
                {
                    playground[Size / 4 * 3, Size / 4 * 3 + i] = 1;
                    playground[Size / 4 * 3 + 5, Size / 4 * 3 + i] = 1;
                    playground[Size / 4 * 3 + i, Size / 4 * 3] = 1;
                    playground[Size / 4 * 3 + i, Size / 4 * 3 + 5] = 1;
                }
            }
            return playground;
        }

        public void OutPut(Graphics gr, Random rnd, int[,] area)
        {
            Particle p = new Particle(rnd, area);
            Color[] Farbe = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue };
            for (int k = 0; k< 5; k++)
            {
                SolidBrush Brush = new SolidBrush(Farbe[k]);
                for (int i = 0; i< 18000; i++)
                {
                    p.RandomWalk();
                    gr.FillRectangle(Brush, (p.position.X + 20), (p.position.Y + 40), 1, 1);
                    area[p.position.X, p.position.Y] = 1;
                    p.start(area);
                }
            }
        }

        public void Message(int size, string info, Graphics gr, Single x, Single y)
        {
            Font drawFont = new Font("Arial", size);
            SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.Black);
            StringFormat drawFormat = new System.Drawing.StringFormat();
            gr.DrawString(info, drawFont, drawBrush, x, y, drawFormat);
        }
       
    }
}
