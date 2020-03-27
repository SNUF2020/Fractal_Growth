namespace Fractal_Growth
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.radioButton_Point = new System.Windows.Forms.RadioButton();
            this.radioButton_Wall = new System.Windows.Forms.RadioButton();
            this.label_Description = new System.Windows.Forms.Label();
            this.groupBox_StartLocation = new System.Windows.Forms.GroupBox();
            this.radioButton_PPP = new System.Windows.Forms.RadioButton();
            this.radioButton_WP = new System.Windows.Forms.RadioButton();
            this.groupBox_StartLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.Location = new System.Drawing.Point(50, 77);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(140, 70);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(50, 195);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(140, 70);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // radioButton_Point
            // 
            this.radioButton_Point.AutoSize = true;
            this.radioButton_Point.Checked = true;
            this.radioButton_Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Point.Location = new System.Drawing.Point(23, 23);
            this.radioButton_Point.Name = "radioButton_Point";
            this.radioButton_Point.Size = new System.Drawing.Size(225, 28);
            this.radioButton_Point.TabIndex = 2;
            this.radioButton_Point.TabStop = true;
            this.radioButton_Point.Text = "Start From Central Point";
            this.radioButton_Point.UseVisualStyleBackColor = true;
            // 
            // radioButton_Wall
            // 
            this.radioButton_Wall.AutoSize = true;
            this.radioButton_Wall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Wall.Location = new System.Drawing.Point(23, 71);
            this.radioButton_Wall.Name = "radioButton_Wall";
            this.radioButton_Wall.Size = new System.Drawing.Size(155, 28);
            this.radioButton_Wall.TabIndex = 3;
            this.radioButton_Wall.Text = "Start From Wall";
            this.radioButton_Wall.UseVisualStyleBackColor = true;
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.Location = new System.Drawing.Point(60, 20);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(488, 29);
            this.label_Description.TabIndex = 4;
            this.label_Description.Text = "Fractal Structure by Diffusion-Limited Growth";
            // 
            // groupBox_StartLocation
            // 
            this.groupBox_StartLocation.Controls.Add(this.radioButton_PPP);
            this.groupBox_StartLocation.Controls.Add(this.radioButton_WP);
            this.groupBox_StartLocation.Controls.Add(this.radioButton_Wall);
            this.groupBox_StartLocation.Controls.Add(this.radioButton_Point);
            this.groupBox_StartLocation.Location = new System.Drawing.Point(254, 67);
            this.groupBox_StartLocation.Name = "groupBox_StartLocation";
            this.groupBox_StartLocation.Size = new System.Drawing.Size(348, 221);
            this.groupBox_StartLocation.TabIndex = 5;
            this.groupBox_StartLocation.TabStop = false;
            // 
            // radioButton_PPP
            // 
            this.radioButton_PPP.AutoSize = true;
            this.radioButton_PPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_PPP.Location = new System.Drawing.Point(23, 172);
            this.radioButton_PPP.Name = "radioButton_PPP";
            this.radioButton_PPP.Size = new System.Drawing.Size(226, 28);
            this.radioButton_PPP.TabIndex = 5;
            this.radioButton_PPP.Text = "Start From Three Points";
            this.radioButton_PPP.UseVisualStyleBackColor = true;
            // 
            // radioButton_WP
            // 
            this.radioButton_WP.AutoSize = true;
            this.radioButton_WP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_WP.Location = new System.Drawing.Point(23, 124);
            this.radioButton_WP.Name = "radioButton_WP";
            this.radioButton_WP.Size = new System.Drawing.Size(303, 28);
            this.radioButton_WP.TabIndex = 4;
            this.radioButton_WP.Text = "Start From Wall and Central Point";
            this.radioButton_WP.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_StartLocation);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Start);
            this.Name = "Form1";
            this.Text = "S.NUF.2020";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_StartLocation.ResumeLayout(false);
            this.groupBox_StartLocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.RadioButton radioButton_Point;
        private System.Windows.Forms.RadioButton radioButton_Wall;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.GroupBox groupBox_StartLocation;
        private System.Windows.Forms.RadioButton radioButton_PPP;
        private System.Windows.Forms.RadioButton radioButton_WP;
    }
}

