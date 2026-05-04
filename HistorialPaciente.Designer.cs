namespace Fase_1_C_
{
    partial class HistorialPaciente
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btningresar = new ReaLTaiizor.Controls.Button();
            btncancelar = new ReaLTaiizor.Controls.Button();
            dgvtriaje = new ReaLTaiizor.Controls.PoisonDataGridView();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            label1 = new Label();
            txtbusqueda = new ReaLTaiizor.Controls.BigTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvtriaje).BeginInit();
            parrotGradientPanel1.SuspendLayout();
            SuspendLayout();
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
            btningresar.Location = new Point(1229, 104);
            btningresar.Name = "btningresar";
            btningresar.PressedBorderColor = Color.DeepSkyBlue;
            btningresar.PressedColor = Color.DeepSkyBlue;
            btningresar.Size = new Size(120, 40);
            btningresar.TabIndex = 78;
            btningresar.Text = "Buscar";
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
            btncancelar.Location = new Point(711, 724);
            btncancelar.Name = "btncancelar";
            btncancelar.PressedBorderColor = Color.DeepSkyBlue;
            btncancelar.PressedColor = Color.DeepSkyBlue;
            btncancelar.Size = new Size(120, 40);
            btncancelar.TabIndex = 77;
            btncancelar.Text = "Regresar";
            btncancelar.TextAlignment = StringAlignment.Center;
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
            dgvtriaje.Location = new Point(24, 172);
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
            dgvtriaje.Size = new Size(1418, 532);
            dgvtriaje.TabIndex = 76;
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.DarkMagenta;
            parrotGradientPanel1.BottomRight = Color.Crimson;
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            parrotGradientPanel1.Controls.Add(label1);
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(-4, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(1473, 66);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 75;
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
            label1.Location = new Point(624, 16);
            label1.Name = "label1";
            label1.Size = new Size(251, 33);
            label1.TabIndex = 0;
            label1.Text = "Historial Pacientes";
            // 
            // txtbusqueda
            // 
            txtbusqueda.BackColor = Color.Transparent;
            txtbusqueda.Font = new Font("Tahoma", 11F);
            txtbusqueda.ForeColor = Color.DimGray;
            txtbusqueda.Image = null;
            txtbusqueda.Location = new Point(76, 103);
            txtbusqueda.MaxLength = 32767;
            txtbusqueda.Multiline = false;
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.ReadOnly = false;
            txtbusqueda.Size = new Size(1089, 41);
            txtbusqueda.TabIndex = 80;
            txtbusqueda.Text = "Ingrese ID del Paciente";
            txtbusqueda.TextAlignment = HorizontalAlignment.Left;
            txtbusqueda.UseSystemPasswordChar = false;
            txtbusqueda.Enter += txtbusqueda_Enter;
            // 
            // HistorialPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 791);
            Controls.Add(txtbusqueda);
            Controls.Add(btningresar);
            Controls.Add(btncancelar);
            Controls.Add(dgvtriaje);
            Controls.Add(parrotGradientPanel1);
            Name = "HistorialPaciente";
            Text = "HistorialPaciente";
            ((System.ComponentModel.ISupportInitialize)dgvtriaje).EndInit();
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.Button btningresar;
        private ReaLTaiizor.Controls.Button btncancelar;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvtriaje;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private Label label1;
        private ReaLTaiizor.Controls.BigTextBox txtbusqueda;
    }
}