using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal_Growth
{
    // Program for description of fractal grwoth
    // 
    // Keeping Form1 as lean as possible all Form-methodes are in class "MainMethodes"
    // description of moving particle (random walk) in class particle
    // QR-code from Code-Bude, see e.g. GitHub

    // S.N.U.F 21.03.2020
    // Last change: 22.03.2020

    // Version 1.0:
    // Different kind of growth (e.g. from wall, from point, etc.)
    // Async mode for growth-methode due to long-term calculation of motion freezing windows 
   
    
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
            int Size = 400;             // definition of scale of playground 

            // Generation of MainMathode instance
            MainMethods Ausgabe = new MainMethods();

            // Definition of output window and return control instance 
            Control outputPBox = Ausgabe.OutPut_Window(); // return Graphics instance for further use

            Graphics g = Graphics.FromImage(outputPBox.BackgroundImage);

            // Generation of playground
            int[,] playground = Ausgabe.PlayGround(g, Size, radioButton_Point, radioButton_Wall, radioButton_WP, radioButton_PPP);

            // Simulate growth
            await Task.Run(() => Ausgabe.OutPut(g, rand, playground));
            // methode running in asynx mode -> no freezing of desktop due to long-time calculation duration of this methode
        }
    }
}
