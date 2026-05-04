namespace Fase_1_C_
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new ReaLTaiizor.Controls.Button();
            panelRedondeado1 = new PanelRedondeado();
            txtcontraseña = new ReaLTaiizor.Controls.BigTextBox();
            txtusuario = new ReaLTaiizor.Controls.BigTextBox();
            button3 = new ReaLTaiizor.Controls.Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new ReaLTaiizor.Controls.Button();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelRedondeado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.Indigo;
            parrotGradientPanel1.BottomRight = Color.Blue;
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            parrotGradientPanel1.Controls.Add(label4);
            parrotGradientPanel1.Controls.Add(pictureBox1);
            parrotGradientPanel1.Controls.Add(button2);
            parrotGradientPanel1.Controls.Add(panelRedondeado1);
            parrotGradientPanel1.Controls.Add(button1);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(1336, 771);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 0;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.DeepSkyBlue;
            parrotGradientPanel1.TopRight = Color.Fuchsia;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(268, 343);
            label4.Name = "label4";
            label4.Size = new Size(262, 44);
            label4.TabIndex = 2;
            label4.Text = "Sistema Triaje";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(133, 303);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BorderColor = Color.Black;
            button2.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button2.EnteredColor = Color.FromArgb(32, 34, 37);
            button2.Font = new Font("Microsoft Sans Serif", 12F);
            button2.Image = null;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.InactiveColor = Color.DarkViolet;
            button2.Location = new Point(466, 634);
            button2.Name = "button2";
            button2.PressedBorderColor = Color.DeepSkyBlue;
            button2.PressedColor = Color.DeepSkyBlue;
            button2.Size = new Size(120, 40);
            button2.TabIndex = 5;
            button2.Text = "Doctor";
            button2.TextAlignment = StringAlignment.Center;
            button2.Click += button2_Click;
            // 
            // panelRedondeado1
            // 
            panelRedondeado1.BackColor = Color.White;
            panelRedondeado1.Controls.Add(txtcontraseña);
            panelRedondeado1.Controls.Add(txtusuario);
            panelRedondeado1.Controls.Add(button3);
            panelRedondeado1.Controls.Add(pictureBox2);
            panelRedondeado1.Controls.Add(label2);
            panelRedondeado1.Controls.Add(label1);
            panelRedondeado1.Location = new Point(728, 92);
            panelRedondeado1.Name = "panelRedondeado1";
            panelRedondeado1.RadioBordes = 30;
            panelRedondeado1.Size = new Size(443, 595);
            panelRedondeado1.TabIndex = 0;
            // 
            // txtcontraseña
            // 
            txtcontraseña.BackColor = Color.Transparent;
            txtcontraseña.Font = new Font("Tahoma", 11F);
            txtcontraseña.ForeColor = Color.DimGray;
            txtcontraseña.Image = null;
            txtcontraseña.Location = new Point(57, 364);
            txtcontraseña.MaxLength = 32767;
            txtcontraseña.Multiline = false;
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.ReadOnly = false;
            txtcontraseña.Size = new Size(325, 41);
            txtcontraseña.TabIndex = 46;
            txtcontraseña.Text = "Contraseña";
            txtcontraseña.TextAlignment = HorizontalAlignment.Left;
            txtcontraseña.UseSystemPasswordChar = false;
            txtcontraseña.Enter += txtcontraseña_Enter;
            // 
            // txtusuario
            // 
            txtusuario.BackColor = Color.Transparent;
            txtusuario.Font = new Font("Tahoma", 11F);
            txtusuario.ForeColor = Color.DimGray;
            txtusuario.Image = null;
            txtusuario.Location = new Point(57, 293);
            txtusuario.MaxLength = 32767;
            txtusuario.Multiline = false;
            txtusuario.Name = "txtusuario";
            txtusuario.ReadOnly = false;
            txtusuario.Size = new Size(325, 41);
            txtusuario.TabIndex = 45;
            txtusuario.Text = "Usuario";
            txtusuario.TextAlignment = HorizontalAlignment.Left;
            txtusuario.UseSystemPasswordChar = false;
            txtusuario.Enter += txtusuario_Enter;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BorderColor = Color.Black;
            button3.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button3.EnteredColor = Color.FromArgb(32, 34, 37);
            button3.Font = new Font("Microsoft Sans Serif", 12F);
            button3.Image = null;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.InactiveColor = Color.DarkViolet;
            button3.Location = new Point(157, 459);
            button3.Name = "button3";
            button3.PressedBorderColor = Color.DeepSkyBlue;
            button3.PressedColor = Color.DeepSkyBlue;
            button3.Size = new Size(120, 40);
            button3.TabIndex = 7;
            button3.Text = "Ingresar";
            button3.TextAlignment = StringAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(177, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(88, 225);
            label2.Name = "label2";
            label2.Size = new Size(266, 24);
            label2.TabIndex = 1;
            label2.Text = "Ingrese sus Credenciales:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(164, 156);
            label1.Name = "label1";
            label1.Size = new Size(109, 42);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.Beige;
            button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button1.EnteredColor = Color.FromArgb(32, 34, 37);
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.DarkViolet;
            button1.Location = new Point(489, 563);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.DeepSkyBlue;
            button1.PressedColor = Color.DeepSkyBlue;
            button1.Size = new Size(120, 40);
            button1.TabIndex = 4;
            button1.Text = "Enfermer@";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 771);
            Controls.Add(parrotGradientPanel1);
            Name = "Login";
            Text = "Form2";
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelRedondeado1.ResumeLayout(false);
            panelRedondeado1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private PanelRedondeado panelRedondeado1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private ReaLTaiizor.Controls.Button button1;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.Button button2;
        private ReaLTaiizor.Controls.Button button3;
        private ReaLTaiizor.Controls.BigTextBox txtcontraseña;
        private ReaLTaiizor.Controls.BigTextBox txtusuario;
    }
}