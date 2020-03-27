using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Fractal_Growth
{
    // Program for description of fractal grwoth
    // 
    // Keeping Form1 as lean as possible all Form-methodes are in class "MainMethodes"
    // description of moving particle (random walk) in class particle
    // QR-code from Code-Bude, see e.g. GitHub

    // S.N.U.F 21.03.2020
    // Last change: 27.03.2020

    // Version 1.1:
    // Different kind of growth (e.g. from wall, from point, etc.)
    // Async mode for growth-methode due to long-term calculation of motion freezing windows 
    // Draw graphic in image of picturebox -> graphic is always visible after mooving behind other windows etc.
    // Necessary for refreshing image: Invalidate methode


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Generation of MainMathode instance
            MainMethods Ausgabe1 = new MainMethods();
            //  Implementation of QR-code to Form1
            Ausgabe1.Create_QRCode(this, "MIT Licence\nCopyright (c) 2020 SNUF2020\n\nhttps://github.com/SNUF2020");
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            this.Close();
        }// Program-End with Exit-Button

        private async void button_Start_Click(object sender, EventArgs e)
        {
            // Definition and Initiation
            Random rand = new Random(); // generation of instance of Random-class. in case of (number) = defined random value
            int Size = 460;             // definition of scale of playground 

            // Generation of MainMathode instance
            MainMethods Ausgabe = new MainMethods();

            // Definition of output window and return control instance 
            Control outputWin = Ausgabe.OutPut_Window(); // return Graphics instance for further use

            // Generation of PicturBox (w/ image) for graphic plotted in
            PictureBox Field = Ausgabe.GenPicBox(outputWin);

            // Generation of Graphics instance correlated to image in picturebox
            Graphics g = Graphics.FromImage(Field.Image);

            // Generation of playground
            int[,] playground = Ausgabe.PlayGround(g, Size, radioButton_Point, radioButton_Wall, radioButton_WP, radioButton_PPP);

            // Simulate growth
            await Task.Run(() => Ausgabe.OutPut(Field, g, rand, playground));
            // methode running in async mode -> no freezing of desktop due to long-time calculation duration of this methode

            // Dispose graphic instance
            g.Dispose();
        }
    }
}
