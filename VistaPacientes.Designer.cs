namespace Fase_1_C_
{
    partial class VistaPacientes
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            label1 = new Label();
            registrosTriajeBindingSource = new BindingSource(components);
            triajeClinicoContextBindingSource = new BindingSource(components);
            pacienteBindingSource = new BindingSource(components);
            vistaPacientesBindingSource = new BindingSource(components);
            dgvtriaje = new ReaLTaiizor.Controls.PoisonDataGridView();
            btningresar = new ReaLTaiizor.Controls.Button();
            btncancelar = new ReaLTaiizor.Controls.Button();
            button1 = new ReaLTaiizor.Controls.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)registrosTriajeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)triajeClinicoContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pacienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vistaPacientesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvtriaje).BeginInit();
            SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.Indigo;
            parrotGradientPanel1.BottomRight = Color.MediumSlateBlue;
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            parrotGradientPanel1.Controls.Add(label1);
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(-4, -4);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(1473, 66);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 70;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.DeepSkyBlue;
            parrotGradientPanel1.TopRight = Color.Fuchsia;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(629, 16);
            label1.Name = "label1";
            label1.Size = new Size(244, 33);
            label1.TabIndex = 0;
            label1.Text = "Listado Pacientes";
            // 
            // dgvtriaje
            // 
            dgvtriaje.AllowUserToResizeRows = false;
            dgvtriaje.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvtriaje.BorderStyle = BorderStyle.None;
            dgvtriaje.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvtriaje.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvtriaje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvtriaje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvtriaje.DefaultCellStyle = dataGridViewCellStyle2;
            dgvtriaje.EnableHeadersVisualStyles = false;
            dgvtriaje.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvtriaje.GridColor = Color.White;
            dgvtriaje.Location = new Point(24, 131);
            dgvtriaje.Name = "dgvtriaje";
            dgvtriaje.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvtriaje.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvtriaje.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvtriaje.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvtriaje.Size = new Size(1151, 581);
            dgvtriaje.TabIndex = 71;
            dgvtriaje.CellContentClick += dgvtriaje_CellContentClick;
            dgvtriaje.CellPainting += dgvtriaje_CellPainting;
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.Transparent;
            btningresar.BorderColor = Color.Black;
            btningresar.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btningresar.EnteredColor = Color.FromArgb(32, 34, 37);
            btningresar.Font = new Font("Microsoft Sans Serif", 12F);
            btningresar.Image = null;
            btningresar.ImageAlign = ContentAlignment.MiddleLeft;
            btningresar.InactiveColor = Color.MediumOrchid;
            btningresar.Location = new Point(1205, 227);
            btningresar.Name = "btningresar";
            btningresar.PressedBorderColor = Color.DeepSkyBlue;
            btningresar.PressedColor = Color.DeepSkyBlue;
            btningresar.Size = new Size(120, 40);
            btningresar.TabIndex = 73;
            btningresar.Text = "Ingresar";
            btningresar.TextAlignment = StringAlignment.Center;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.Transparent;
            btncancelar.BorderColor = Color.Black;
            btncancelar.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btncancelar.EnteredColor = Color.FromArgb(32, 34, 37);
            btncancelar.Font = new Font("Microsoft Sans Serif", 12F);
            btncancelar.Image = null;
            btncancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btncancelar.InactiveColor = Color.LightCoral;
            btncancelar.Location = new Point(1205, 292);
            btncancelar.Name = "btncancelar";
            btncancelar.PressedBorderColor = Color.DeepSkyBlue;
            btncancelar.PressedColor = Color.DeepSkyBlue;
            btncancelar.Size = new Size(120, 40);
            btncancelar.TabIndex = 72;
            btncancelar.Text = "Ver mis Pacientes";
            btncancelar.TextAlignment = StringAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.Black;
            button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button1.EnteredColor = Color.FromArgb(32, 34, 37);
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.HotPink;
            button1.Location = new Point(1202, 403);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.DeepSkyBlue;
            button1.PressedColor = Color.DeepSkyBlue;
            button1.Size = new Size(138, 40);
            button1.TabIndex = 74;
            button1.Text = "Buscar Historial Paciente";
            button1.TextAlignment = StringAlignment.Center;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // VistaPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 753);
            Controls.Add(button1);
            Controls.Add(btningresar);
            Controls.Add(btncancelar);
            Controls.Add(dgvtriaje);
            Controls.Add(parrotGradientPanel1);
            Name = "VistaPacientes";
            Text = "VistaPacientes";
            Load += VistaPacientes_Load;
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)registrosTriajeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)triajeClinicoContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pacienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vistaPacientesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvtriaje).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private Label label1;
        private BindingSource registrosTriajeBindingSource;
        private BindingSource vistaPacientesBindingSource;
        private BindingSource triajeClinicoContextBindingSource;
        private BindingSource pacienteBindingSource;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvtriaje;
        private ReaLTaiizor.Controls.Button btningresar;
        private ReaLTaiizor.Controls.Button btncancelar;
        private ReaLTaiizor.Controls.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}