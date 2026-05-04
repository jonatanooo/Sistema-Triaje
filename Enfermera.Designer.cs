namespace Fase_1_C_
{
    partial class Enfermera
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            rdbDesmayoSi = new ReaLTaiizor.Controls.MaterialRadioButton();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            panelRedondeado1 = new PanelRedondeado();
            rdbDesmayoNo = new ReaLTaiizor.Controls.MaterialRadioButton();
            label14 = new Label();
            txtnombre = new ReaLTaiizor.Controls.BigTextBox();
            txtapellidos = new ReaLTaiizor.Controls.BigTextBox();
            panelRedondeado2 = new PanelRedondeado();
            rdbHemorragiaNo = new ReaLTaiizor.Controls.MaterialRadioButton();
            rdbHemorragiaSi = new ReaLTaiizor.Controls.MaterialRadioButton();
            panelRedondeado3 = new PanelRedondeado();
            rdbDificultadadResNo = new ReaLTaiizor.Controls.MaterialRadioButton();
            rdbDificultadadResSi = new ReaLTaiizor.Controls.MaterialRadioButton();
            panelRedondeado4 = new PanelRedondeado();
            rdbTraumaCraneoNo = new ReaLTaiizor.Controls.MaterialRadioButton();
            rdbTraumaCraneoSi = new ReaLTaiizor.Controls.MaterialRadioButton();
            panelRedondeado5 = new PanelRedondeado();
            rdbDolorPechoNo = new ReaLTaiizor.Controls.MaterialRadioButton();
            rdbDolorPechoSi = new ReaLTaiizor.Controls.MaterialRadioButton();
            numdolor = new ReaLTaiizor.Controls.HopeNumeric();
            numtemperatura = new ReaLTaiizor.Controls.HopeNumeric();
            numoxigeno = new ReaLTaiizor.Controls.HopeNumeric();
            numevolucion = new ReaLTaiizor.Controls.HopeNumeric();
            cbmotivo = new ReaLTaiizor.Controls.PoisonComboBox();
            cbestadomental = new ReaLTaiizor.Controls.PoisonComboBox();
            cbmecanismo = new ReaLTaiizor.Controls.PoisonComboBox();
            btncancelar = new ReaLTaiizor.Controls.Button();
            btningresar = new ReaLTaiizor.Controls.Button();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label15 = new Label();
            label16 = new Label();
            txtdui = new ReaLTaiizor.Controls.BigTextBox();
            dateedad = new ReaLTaiizor.Controls.PoisonDateTime();
            label17 = new Label();
            cbgenero = new ReaLTaiizor.Controls.PoisonComboBox();
            panelRedondeado1.SuspendLayout();
            panelRedondeado2.SuspendLayout();
            panelRedondeado3.SuspendLayout();
            panelRedondeado4.SuspendLayout();
            panelRedondeado5.SuspendLayout();
            parrotGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(570, 21);
            label1.Name = "label1";
            label1.Size = new Size(299, 33);
            label1.TabIndex = 0;
            label1.Text = "Registro de Pacientes";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ebrima", 12F);
            label2.Location = new Point(52, 192);
            label2.Name = "label2";
            label2.Size = new Size(403, 21);
            label2.TabIndex = 1;
            label2.Text = "¿El paciente presenta pérdida de consciencia o desmayo?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ebrima", 12F);
            label3.Location = new Point(52, 245);
            label3.Name = "label3";
            label3.Size = new Size(287, 21);
            label3.TabIndex = 2;
            label3.Text = "¿Existe hemorragia activa incontrolable?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Ebrima", 12F);
            label4.Location = new Point(51, 299);
            label4.Name = "label4";
            label4.Size = new Size(581, 21);
            label4.TabIndex = 3;
            label4.Text = "¿Presenta dificultad respiratoria severa (se ahoga o tiene cianosis/coloración azul)?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Ebrima", 12F);
            label5.Location = new Point(52, 361);
            label5.Name = "label5";
            label5.Size = new Size(507, 21);
            label5.TabIndex = 4;
            label5.Text = "¿Sufrió un trauma craneoencefálico (golpe fuerte en la cabeza) reciente?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Ebrima", 12F);
            label6.Location = new Point(51, 417);
            label6.Name = "label6";
            label6.Size = new Size(450, 21);
            label6.TabIndex = 5;
            label6.Text = "¿Siente dolor opresivo en el pecho irradiado al brazo izquierdo?";
            // 
            // rdbDesmayoSi
            // 
            rdbDesmayoSi.AutoSize = true;
            rdbDesmayoSi.Depth = 0;
            rdbDesmayoSi.Font = new Font("Segoe UI Symbol", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbDesmayoSi.Location = new Point(25, 1);
            rdbDesmayoSi.Margin = new Padding(0);
            rdbDesmayoSi.MouseLocation = new Point(-1, -1);
            rdbDesmayoSi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdbDesmayoSi.Name = "rdbDesmayoSi";
            rdbDesmayoSi.Ripple = true;
            rdbDesmayoSi.Size = new Size(49, 37);
            rdbDesmayoSi.TabIndex = 20;
            rdbDesmayoSi.TabStop = true;
            rdbDesmayoSi.Text = "Si";
            rdbDesmayoSi.UseAccentColor = false;
            rdbDesmayoSi.UseVisualStyleBackColor = true;
            rdbDesmayoSi.CheckedChanged += materialRadioButton1_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Ebrima", 12F);
            label7.Location = new Point(955, 303);
            label7.Name = "label7";
            label7.Size = new Size(184, 21);
            label7.TabIndex = 24;
            label7.Text = "Escala del Dolor (1 al 10):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Ebrima", 12F);
            label8.Location = new Point(955, 354);
            label8.Name = "label8";
            label8.Size = new Size(197, 21);
            label8.TabIndex = 25;
            label8.Text = "Temperatura Corporal (°C):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Ebrima", 12F);
            label9.Location = new Point(955, 405);
            label9.Name = "label9";
            label9.Size = new Size(240, 21);
            label9.TabIndex = 26;
            label9.Text = "Saturación de Oxígeno (SpO2 %):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Ebrima", 12F);
            label10.Location = new Point(955, 454);
            label10.Name = "label10";
            label10.Size = new Size(243, 42);
            label10.TabIndex = 27;
            label10.Text = "Tiempo de evolución del síntoma \r\nprincipal (horas):";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Ebrima", 12F);
            label11.Location = new Point(52, 501);
            label11.Name = "label11";
            label11.Size = new Size(209, 21);
            label11.TabIndex = 28;
            label11.Text = "Motivo principal de consulta:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Ebrima", 12F);
            label12.Location = new Point(52, 551);
            label12.Name = "label12";
            label12.Size = new Size(266, 42);
            label12.TabIndex = 29;
            label12.Text = "Estado mental / Nivel de consciencia \r\n(Escala de Glasgow simplificada):";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Ebrima", 12F);
            label13.Location = new Point(52, 623);
            label13.Name = "label13";
            label13.Size = new Size(228, 21);
            label13.TabIndex = 30;
            label13.Text = "Mecanismo de lesión (si aplica):";
            // 
            // panelRedondeado1
            // 
            panelRedondeado1.BackColor = SystemColors.InactiveBorder;
            panelRedondeado1.Controls.Add(rdbDesmayoNo);
            panelRedondeado1.Controls.Add(rdbDesmayoSi);
            panelRedondeado1.Location = new Point(638, 180);
            panelRedondeado1.Name = "panelRedondeado1";
            panelRedondeado1.RadioBordes = 30;
            panelRedondeado1.Size = new Size(184, 38);
            panelRedondeado1.TabIndex = 41;
            // 
            // rdbDesmayoNo
            // 
            rdbDesmayoNo.AutoSize = true;
            rdbDesmayoNo.Depth = 0;
            rdbDesmayoNo.Font = new Font("Segoe UI Symbol", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbDesmayoNo.Location = new Point(93, 1);
            rdbDesmayoNo.Margin = new Padding(0);
            rdbDesmayoNo.MouseLocation = new Point(-1, -1);
            rdbDesmayoNo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdbDesmayoNo.Name = "rdbDesmayoNo";
            rdbDesmayoNo.Ripple = true;
            rdbDesmayoNo.Size = new Size(55, 37);
            rdbDesmayoNo.TabIndex = 42;
            rdbDesmayoNo.TabStop = true;
            rdbDesmayoNo.Text = "No";
            rdbDesmayoNo.UseAccentColor = false;
            rdbDesmayoNo.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(52, 116);
            label14.Name = "label14";
            label14.Size = new Size(313, 21);
            label14.TabIndex = 42;
            label14.Text = "Ingrese el Nombres y Apellidos del Paciente";
            // 
            // txtnombre
            // 
            txtnombre.BackColor = Color.Transparent;
            txtnombre.Font = new Font("Tahoma", 11F);
            txtnombre.ForeColor = Color.DimGray;
            txtnombre.Image = null;
            txtnombre.Location = new Point(402, 110);
            txtnombre.MaxLength = 32767;
            txtnombre.Multiline = false;
            txtnombre.Name = "txtnombre";
            txtnombre.ReadOnly = false;
            txtnombre.Size = new Size(325, 41);
            txtnombre.TabIndex = 43;
            txtnombre.Text = "Nombres";
            txtnombre.TextAlignment = HorizontalAlignment.Left;
            txtnombre.UseSystemPasswordChar = false;
            txtnombre.TextChanged += txtnombre_TextChanged;
            txtnombre.Enter += txtnombre_Enter;
            // 
            // txtapellidos
            // 
            txtapellidos.BackColor = Color.Transparent;
            txtapellidos.Font = new Font("Tahoma", 11F);
            txtapellidos.ForeColor = Color.DimGray;
            txtapellidos.Image = null;
            txtapellidos.Location = new Point(752, 110);
            txtapellidos.MaxLength = 32767;
            txtapellidos.Multiline = false;
            txtapellidos.Name = "txtapellidos";
            txtapellidos.ReadOnly = false;
            txtapellidos.Size = new Size(325, 41);
            txtapellidos.TabIndex = 44;
            txtapellidos.Text = "Apellidos";
            txtapellidos.TextAlignment = HorizontalAlignment.Left;
            txtapellidos.UseSystemPasswordChar = false;
            txtapellidos.Enter += txtapellidos_Enter;
            // 
            // panelRedondeado2
            // 
            panelRedondeado2.BackColor = SystemColors.InactiveBorder;
            panelRedondeado2.Controls.Add(rdbHemorragiaNo);
            panelRedondeado2.Controls.Add(rdbHemorragiaSi);
            panelRedondeado2.Location = new Point(638, 238);
            panelRedondeado2.Name = "panelRedondeado2";
            panelRedondeado2.RadioBordes = 30;
            panelRedondeado2.Size = new Size(184, 38);
            panelRedondeado2.TabIndex = 45;
            // 
            // rdbHemorragiaNo
            // 
            rdbHemorragiaNo.AutoSize = true;
            rdbHemorragiaNo.Depth = 0;
            rdbHemorragiaNo.Font = new Font("Segoe UI Symbol", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbHemorragiaNo.Location = new Point(93, 1);
            rdbHemorragiaNo.Margin = new Padding(0);
            rdbHemorragiaNo.MouseLocation = new Point(-1, -1);
            rdbHemorragiaNo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdbHemorragiaNo.Name = "rdbHemorragiaNo";
            rdbHemorragiaNo.Ripple = true;
            rdbHemorragiaNo.Size = new Size(55, 37);
            rdbHemorragiaNo.TabIndex = 42;
            rdbHemorragiaNo.TabStop = true;
            rdbHemorragiaNo.Text = "No";
            rdbHemorragiaNo.UseAccentColor = false;
            rdbHemorragiaNo.UseVisualStyleBackColor = true;
            // 
            // rdbHemorragiaSi
            // 
            rdbHemorragiaSi.AutoSize = true;
            rdbHemorragiaSi.Depth = 0;
            rdbHemorragiaSi.Font = new Font("Segoe UI Symbol", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbHemorragiaSi.Location = new Point(25, 1);
            rdbHemorragiaSi.Margin = new Padding(0);
            rdbHemorragiaSi.MouseLocation = new Point(-1, -1);
            rdbHemorragiaSi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdbHemorragiaSi.Name = "rdbHemorragiaSi";
            rdbHemorragiaSi.Ripple = true;
            rdbHemorragiaSi.Size = new Size(49, 37);
            rdbHemorragiaSi.TabIndex = 20;
            rdbHemorragiaSi.TabStop = true;
            rdbHemorragiaSi.Text = "Si";
            rdbHemorragiaSi.UseAccentColor = false;
            rdbHemorragiaSi.UseVisualStyleBackColor = true;
            // 
            // panelRedondeado3
            // 
            panelRedondeado3.BackColor = SystemColors.InactiveBorder;
            panelRedondeado3.Controls.Add(rdbDificultadadResNo);
            panelRedondeado3.Controls.Add(rdbDificultadadResSi);
            panelRedondeado3.Location = new Point(638, 292);
            panelRedondeado3.Name = "panelRedondeado3";
            panelRedondeado3.RadioBordes = 30;
            panelRedondeado3.Size = new Size(184, 38);
            panelRedondeado3.TabIndex = 46;
            // 
            // rdbDificultadadResNo
            // 
            rdbDificultadadResNo.AutoSize = true;
            rdbDificultadadResNo.Depth = 0;
            rdbDificultadadResNo.Font = new Font("Segoe UI Symbol", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbDificultadadResNo.Location = new Point(93, 1);
            rdbDificultadadResNo.Margin = new Padding(0);
            rdbDificultadadResNo.MouseLocation = new Point(-1, -1);
            rdbDificultadadResNo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdbDificultadadResNo.Name = "rdbDificultadadResNo";
            rdbDificultadadResNo.Ripple = true;
            rdbDificultadadResNo.Size = new Size(55, 37);
            rdbDificultadadResNo.TabIndex = 42;
            rdbDificultadadResNo.TabStop = true;
            rdbDificultadadResNo.Text = "No";
            rdbDificultadadResNo.UseAccentColor = false;
            rdbDificultadadResNo.UseVisualStyleBackColor = true;
            // 
            // rdbDificultadadResSi
            // 
            rdbDificultadadResSi.AutoSize = true;
            rdbDificultadadResSi.Depth = 0;
            rdbDificultadadResSi.Font = new Font("Segoe UI Symbol", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbDificultadadResSi.Location = new Point(25, 1);
            rdbDificultadadResSi.Margin = new Padding(0);
            rdbDificultadadResSi.MouseLocation = new Point(-1, -1);
            rdbDificultadadResSi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdbDificultadadResSi.Name = "rdbDificultadadResSi";
            rdbDificultadadResSi.Ripple = true;
            rdbDificultadadResSi.Size = new Size(49, 37);
            rdbDificultadadResSi.TabIndex = 20;
            rdbDificultadadResSi.TabStop = true;
            rdbDificultadadResSi.Text = "Si";
            rdbDificultadadResSi.UseAccentColor = false;
            rdbDificultadadResSi.UseVisualStyleBackColor = true;
            // 
            // panelRedondeado4
            // 
            panelRedondeado4.BackColor = SystemColors.InactiveBorder;
            panelRedondeado4.Controls.Add(rdbTraumaCraneoNo);
            panelRedondeado4.Controls.Add(rdbTraumaCraneoSi);
            panelRedondeado4.Location = new Point(638, 351);
            panelRedondeado4.Name = "panelRedondeado4";
            panelRedondeado4.RadioBordes = 30;
            panelRedondeado4.Size = new Size(184, 38);
            panelRedondeado4.TabIndex = 47;
            // 
            // rdbTraumaCraneoNo
            // 
            rdbTraumaCraneoNo.AutoSize = true;
            rdbTraumaCraneoNo.Depth = 0;
            rdbTraumaCraneoNo.Font = new Font("Segoe UI Symbol", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbTraumaCraneoNo.Location = new Point(93, 1);
            rdbTraumaCraneoNo.Margin = new Padding(0);
            rdbTraumaCraneoNo.MouseLocation = new Point(-1, -1);
            rdbTraumaCraneoNo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdbTraumaCraneoNo.Name = "rdbTraumaCraneoNo";
            rdbTraumaCraneoNo.Ripple = true;
            rdbTraumaCraneoNo.Size = new Size(55, 37);
            rdbTraumaCraneoNo.TabIndex = 42;
            rdbTraumaCraneoNo.TabStop = true;
            rdbTraumaCraneoNo.Text = "No";
            rdbTraumaCraneoNo.UseAccentColor = false;
            rdbTraumaCraneoNo.UseVisualStyleBackColor = true;
            // 
            // rdbTraumaCraneoSi
            // 
            rdbTraumaCraneoSi.AutoSize = true;
            rdbTraumaCraneoSi.Depth = 0;
            rdbTraumaCraneoSi.Font = new Font("Segoe UI Symbol", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbTraumaCraneoSi.Location = new Point(25, 1);
            rdbTraumaCraneoSi.Margin = new Padding(0);
            rdbTraumaCraneoSi.MouseLocation = new Point(-1, -1);
            rdbTraumaCraneoSi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdbTraumaCraneoSi.Name = "rdbTraumaCraneoSi";
            rdbTraumaCraneoSi.Ripple = true;
            rdbTraumaCraneoSi.Size = new Size(49, 37);
            rdbTraumaCraneoSi.TabIndex = 20;
            rdbTraumaCraneoSi.TabStop = true;
            rdbTraumaCraneoSi.Text = "Si";
            rdbTraumaCraneoSi.UseAccentColor = false;
            rdbTraumaCraneoSi.UseVisualStyleBackColor = true;
            // 
            // panelRedondeado5
            // 
            panelRedondeado5.BackColor = SystemColors.InactiveBorder;
            panelRedondeado5.Controls.Add(rdbDolorPechoNo);
            panelRedondeado5.Controls.Add(rdbDolorPechoSi);
            panelRedondeado5.Location = new Point(638, 410);
            panelRedondeado5.Name = "panelRedondeado5";
            panelRedondeado5.RadioBordes = 30;
            panelRedondeado5.Size = new Size(184, 38);
            panelRedondeado5.TabIndex = 48;
            // 
            // rdbDolorPechoNo
            // 
            rdbDolorPechoNo.AutoSize = true;
            rdbDolorPechoNo.Depth = 0;
            rdbDolorPechoNo.Font = new Font("Segoe UI Symbol", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbDolorPechoNo.Location = new Point(93, 1);
            rdbDolorPechoNo.Margin = new Padding(0);
            rdbDolorPechoNo.MouseLocation = new Point(-1, -1);
            rdbDolorPechoNo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdbDolorPechoNo.Name = "rdbDolorPechoNo";
            rdbDolorPechoNo.Ripple = true;
            rdbDolorPechoNo.Size = new Size(55, 37);
            rdbDolorPechoNo.TabIndex = 42;
            rdbDolorPechoNo.TabStop = true;
            rdbDolorPechoNo.Text = "No";
            rdbDolorPechoNo.UseAccentColor = false;
            rdbDolorPechoNo.UseVisualStyleBackColor = true;
            // 
            // rdbDolorPechoSi
            // 
            rdbDolorPechoSi.AutoSize = true;
            rdbDolorPechoSi.Depth = 0;
            rdbDolorPechoSi.Font = new Font("Segoe UI Symbol", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbDolorPechoSi.Location = new Point(25, 1);
            rdbDolorPechoSi.Margin = new Padding(0);
            rdbDolorPechoSi.MouseLocation = new Point(-1, -1);
            rdbDolorPechoSi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdbDolorPechoSi.Name = "rdbDolorPechoSi";
            rdbDolorPechoSi.Ripple = true;
            rdbDolorPechoSi.Size = new Size(49, 37);
            rdbDolorPechoSi.TabIndex = 20;
            rdbDolorPechoSi.TabStop = true;
            rdbDolorPechoSi.Text = "Si";
            rdbDolorPechoSi.UseAccentColor = false;
            rdbDolorPechoSi.UseVisualStyleBackColor = true;
            // 
            // numdolor
            // 
            numdolor.BackColor = Color.White;
            numdolor.BaseColor = Color.FromArgb(242, 246, 252);
            numdolor.BorderColorA = Color.FromArgb(192, 196, 204);
            numdolor.BorderColorB = Color.FromArgb(192, 196, 204);
            numdolor.BorderHoverColorA = Color.FromArgb(64, 158, 255);
            numdolor.ButtonTextColorA = Color.FromArgb(144, 147, 153);
            numdolor.ButtonTextColorB = Color.FromArgb(144, 147, 153);
            numdolor.EnterKey = true;
            numdolor.Font = new Font("Segoe UI", 12F);
            numdolor.ForeColor = Color.Black;
            numdolor.HoverButtonTextColorA = Color.FromArgb(64, 158, 255);
            numdolor.HoverButtonTextColorB = Color.FromArgb(64, 158, 255);
            numdolor.Location = new Point(1205, 297);
            numdolor.MaxNum = 10F;
            numdolor.MinimumSize = new Size(1, 1);
            numdolor.MinNum = 0F;
            numdolor.Name = "numdolor";
            numdolor.Precision = 0;
            numdolor.Size = new Size(120, 32);
            numdolor.Step = 1F;
            numdolor.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            numdolor.TabIndex = 55;
            numdolor.Text = "hopeNumeric1";
            numdolor.ValueNumber = 0F;
            // 
            // numtemperatura
            // 
            numtemperatura.BackColor = Color.White;
            numtemperatura.BaseColor = Color.FromArgb(242, 246, 252);
            numtemperatura.BorderColorA = Color.FromArgb(192, 196, 204);
            numtemperatura.BorderColorB = Color.FromArgb(192, 196, 204);
            numtemperatura.BorderHoverColorA = Color.FromArgb(64, 158, 255);
            numtemperatura.ButtonTextColorA = Color.FromArgb(144, 147, 153);
            numtemperatura.ButtonTextColorB = Color.FromArgb(144, 147, 153);
            numtemperatura.EnterKey = true;
            numtemperatura.Font = new Font("Segoe UI", 12F);
            numtemperatura.ForeColor = Color.Black;
            numtemperatura.HoverButtonTextColorA = Color.FromArgb(64, 158, 255);
            numtemperatura.HoverButtonTextColorB = Color.FromArgb(64, 158, 255);
            numtemperatura.Location = new Point(1205, 351);
            numtemperatura.MaxNum = 45F;
            numtemperatura.MinimumSize = new Size(1, 1);
            numtemperatura.MinNum = 32F;
            numtemperatura.Name = "numtemperatura";
            numtemperatura.Precision = 1;
            numtemperatura.Size = new Size(120, 32);
            numtemperatura.Step = 1F;
            numtemperatura.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            numtemperatura.TabIndex = 56;
            numtemperatura.Text = "hopeNumeric2";
            numtemperatura.ValueNumber = 32F;
            numtemperatura.Click += hopeNumeric2_Click;
            // 
            // numoxigeno
            // 
            numoxigeno.BackColor = Color.White;
            numoxigeno.BaseColor = Color.FromArgb(242, 246, 252);
            numoxigeno.BorderColorA = Color.FromArgb(192, 196, 204);
            numoxigeno.BorderColorB = Color.FromArgb(192, 196, 204);
            numoxigeno.BorderHoverColorA = Color.FromArgb(64, 158, 255);
            numoxigeno.ButtonTextColorA = Color.FromArgb(144, 147, 153);
            numoxigeno.ButtonTextColorB = Color.FromArgb(144, 147, 153);
            numoxigeno.EnterKey = true;
            numoxigeno.Font = new Font("Segoe UI", 12F);
            numoxigeno.ForeColor = Color.Black;
            numoxigeno.HoverButtonTextColorA = Color.FromArgb(64, 158, 255);
            numoxigeno.HoverButtonTextColorB = Color.FromArgb(64, 158, 255);
            numoxigeno.Location = new Point(1205, 404);
            numoxigeno.MaxNum = 100F;
            numoxigeno.MinimumSize = new Size(0, 1);
            numoxigeno.MinNum = 0F;
            numoxigeno.Name = "numoxigeno";
            numoxigeno.Precision = 1;
            numoxigeno.Size = new Size(120, 32);
            numoxigeno.Step = 1F;
            numoxigeno.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            numoxigeno.TabIndex = 57;
            numoxigeno.Text = "hopeNumeric3";
            numoxigeno.ValueNumber = 0F;
            // 
            // numevolucion
            // 
            numevolucion.BackColor = Color.White;
            numevolucion.BaseColor = Color.FromArgb(242, 246, 252);
            numevolucion.BorderColorA = Color.FromArgb(192, 196, 204);
            numevolucion.BorderColorB = Color.FromArgb(192, 196, 204);
            numevolucion.BorderHoverColorA = Color.FromArgb(64, 158, 255);
            numevolucion.ButtonTextColorA = Color.FromArgb(144, 147, 153);
            numevolucion.ButtonTextColorB = Color.FromArgb(144, 147, 153);
            numevolucion.EnterKey = true;
            numevolucion.Font = new Font("Segoe UI", 12F);
            numevolucion.ForeColor = Color.Black;
            numevolucion.HoverButtonTextColorA = Color.FromArgb(64, 158, 255);
            numevolucion.HoverButtonTextColorB = Color.FromArgb(64, 158, 255);
            numevolucion.Location = new Point(1206, 455);
            numevolucion.MaxNum = 300F;
            numevolucion.MinimumSize = new Size(1, 1);
            numevolucion.MinNum = 0F;
            numevolucion.Name = "numevolucion";
            numevolucion.Precision = 1;
            numevolucion.Size = new Size(120, 32);
            numevolucion.Step = 1F;
            numevolucion.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            numevolucion.TabIndex = 58;
            numevolucion.Text = "hopeNumeric4";
            numevolucion.ValueNumber = 0F;
            // 
            // cbmotivo
            // 
            cbmotivo.FormattingEnabled = true;
            cbmotivo.ItemHeight = 23;
            cbmotivo.Items.AddRange(new object[] { "Traumatismo / Accidente", "Problemas Respiratorios", "Dolor Abdominal / Gastrointestinal", "Fiebre / Infección", "Consulta General / Rutina", "Sospecha de derrame (ACV)", "Reacción alérgica grave", "Dolor en el pecho / Problemas cardíacos", "Intoxicación / Envenenamiento / Sobredosis", "Convulsiones / Epilepsia", "Crisis de salud mental / Agitación", "Emergencia Obstétrica / Embarazo", "Dolor de cabeza severo / Migraña extrema", "Problemas urinarios / Renales", "Lesiones menores / Cortes superficiales", "Dolor muscular / Articular crónico", "Problemas en la piel / Erupciones Leve ", "Resfriado común / Tos leve" });
            cbmotivo.Location = new Point(320, 500);
            cbmotivo.Name = "cbmotivo";
            cbmotivo.Size = new Size(292, 29);
            cbmotivo.TabIndex = 64;
            cbmotivo.UseSelectable = true;
            // 
            // cbestadomental
            // 
            cbestadomental.FormattingEnabled = true;
            cbestadomental.ItemHeight = 23;
            cbestadomental.Items.AddRange(new object[] { "Alerta y orientado", "Responde a estimulos verbales", "Responde solo al dolor", "Inconsciente" });
            cbestadomental.Location = new Point(320, 561);
            cbestadomental.Name = "cbestadomental";
            cbestadomental.Size = new Size(292, 29);
            cbestadomental.TabIndex = 65;
            cbestadomental.UseSelectable = true;
            // 
            // cbmecanismo
            // 
            cbmecanismo.FormattingEnabled = true;
            cbmecanismo.ItemHeight = 23;
            cbmecanismo.Items.AddRange(new object[] { "Caída desde su propia altura", "Accidente de transito", "Quemadura", "Corte / Herida punzante", "No aplica" });
            cbmecanismo.Location = new Point(320, 622);
            cbmecanismo.Name = "cbmecanismo";
            cbmecanismo.Size = new Size(292, 29);
            cbmecanismo.TabIndex = 66;
            cbmecanismo.UseSelectable = true;
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
            btncancelar.Location = new Point(477, 694);
            btncancelar.Name = "btncancelar";
            btncancelar.PressedBorderColor = Color.DeepSkyBlue;
            btncancelar.PressedColor = Color.DeepSkyBlue;
            btncancelar.Size = new Size(120, 40);
            btncancelar.TabIndex = 67;
            btncancelar.Text = "Cancelar";
            btncancelar.TextAlignment = StringAlignment.Center;
            btncancelar.Click += btncancelar_Click;
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
            btningresar.Location = new Point(793, 694);
            btningresar.Name = "btningresar";
            btningresar.PressedBorderColor = Color.DeepSkyBlue;
            btningresar.PressedColor = Color.DeepSkyBlue;
            btningresar.Size = new Size(120, 40);
            btningresar.TabIndex = 68;
            btningresar.Text = "Ingresar";
            btningresar.TextAlignment = StringAlignment.Center;
            btningresar.Click += btningresar_Click;
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.Indigo;
            parrotGradientPanel1.BottomRight = Color.MediumSlateBlue;
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            parrotGradientPanel1.Controls.Add(label1);
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(-17, -6);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(1434, 73);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 69;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.DeepSkyBlue;
            parrotGradientPanel1.TopRight = Color.Fuchsia;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Location = new Point(59, 453);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 1);
            panel1.TabIndex = 70;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.Location = new Point(59, 398);
            panel2.Name = "panel2";
            panel2.Size = new Size(771, 1);
            panel2.TabIndex = 71;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Indigo;
            panel3.Location = new Point(59, 337);
            panel3.Name = "panel3";
            panel3.Size = new Size(771, 1);
            panel3.TabIndex = 72;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Indigo;
            panel4.Location = new Point(59, 281);
            panel4.Name = "panel4";
            panel4.Size = new Size(771, 1);
            panel4.TabIndex = 73;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Indigo;
            panel5.Location = new Point(59, 225);
            panel5.Name = "panel5";
            panel5.Size = new Size(771, 1);
            panel5.TabIndex = 74;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Ebrima", 12F);
            label15.Location = new Point(1097, 123);
            label15.Name = "label15";
            label15.Size = new Size(47, 21);
            label15.TabIndex = 75;
            label15.Text = "Edad:\r\n";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Ebrima", 12F);
            label16.Location = new Point(955, 245);
            label16.Name = "label16";
            label16.Size = new Size(39, 21);
            label16.TabIndex = 77;
            label16.Text = "DUI:";
            // 
            // txtdui
            // 
            txtdui.BackColor = Color.Transparent;
            txtdui.Font = new Font("Tahoma", 11F);
            txtdui.ForeColor = Color.DimGray;
            txtdui.Image = null;
            txtdui.Location = new Point(1000, 237);
            txtdui.MaxLength = 32767;
            txtdui.Multiline = false;
            txtdui.Name = "txtdui";
            txtdui.ReadOnly = false;
            txtdui.Size = new Size(326, 41);
            txtdui.TabIndex = 78;
            txtdui.Text = "Ingrese numero de DUI";
            txtdui.TextAlignment = HorizontalAlignment.Left;
            txtdui.UseSystemPasswordChar = false;
            txtdui.Enter += txtdui_Enter;
            // 
            // dateedad
            // 
            dateedad.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dateedad.Location = new Point(1150, 120);
            dateedad.MinimumSize = new Size(0, 29);
            dateedad.Name = "dateedad";
            dateedad.Size = new Size(178, 29);
            dateedad.TabIndex = 79;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Ebrima", 12F);
            label17.Location = new Point(955, 190);
            label17.Name = "label17";
            label17.Size = new Size(64, 21);
            label17.TabIndex = 80;
            label17.Text = "Genero:";
            // 
            // cbgenero
            // 
            cbgenero.FormattingEnabled = true;
            cbgenero.ItemHeight = 23;
            cbgenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cbgenero.Location = new Point(1033, 189);
            cbgenero.Name = "cbgenero";
            cbgenero.Size = new Size(292, 29);
            cbgenero.TabIndex = 81;
            cbgenero.UseSelectable = true;
            // 
            // Enfermera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1391, 800);
            Controls.Add(cbgenero);
            Controls.Add(label17);
            Controls.Add(dateedad);
            Controls.Add(txtdui);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(parrotGradientPanel1);
            Controls.Add(btningresar);
            Controls.Add(btncancelar);
            Controls.Add(cbmecanismo);
            Controls.Add(cbestadomental);
            Controls.Add(cbmotivo);
            Controls.Add(numevolucion);
            Controls.Add(numoxigeno);
            Controls.Add(numtemperatura);
            Controls.Add(numdolor);
            Controls.Add(panelRedondeado5);
            Controls.Add(panelRedondeado4);
            Controls.Add(panelRedondeado3);
            Controls.Add(panelRedondeado2);
            Controls.Add(txtapellidos);
            Controls.Add(txtnombre);
            Controls.Add(label14);
            Controls.Add(label2);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panelRedondeado1);
            Name = "Enfermera";
            Text = "Edad:";
            Load += Enfermera_Load;
            panelRedondeado1.ResumeLayout(false);
            panelRedondeado1.PerformLayout();
            panelRedondeado2.ResumeLayout(false);
            panelRedondeado2.PerformLayout();
            panelRedondeado3.ResumeLayout(false);
            panelRedondeado3.PerformLayout();
            panelRedondeado4.ResumeLayout(false);
            panelRedondeado4.PerformLayout();
            panelRedondeado5.ResumeLayout(false);
            panelRedondeado5.PerformLayout();
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ReaLTaiizor.Controls.MaterialRadioButton rdbDesmayoSi;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private PanelRedondeado panelRedondeado1;
        private ReaLTaiizor.Controls.MaterialRadioButton rdbDesmayoNo;
        private Label label14;
        private ReaLTaiizor.Controls.BigTextBox txtnombre;
        private ReaLTaiizor.Controls.BigTextBox txtapellidos;
        private PanelRedondeado panelRedondeado2;
        private ReaLTaiizor.Controls.MaterialRadioButton rdbHemorragiaNo;
        private ReaLTaiizor.Controls.MaterialRadioButton rdbHemorragiaSi;
        private PanelRedondeado panelRedondeado3;
        private ReaLTaiizor.Controls.MaterialRadioButton rdbDificultadadResNo;
        private ReaLTaiizor.Controls.MaterialRadioButton rdbDificultadadResSi;
        private PanelRedondeado panelRedondeado4;
        private ReaLTaiizor.Controls.MaterialRadioButton rdbTraumaCraneoNo;
        private ReaLTaiizor.Controls.MaterialRadioButton rdbTraumaCraneoSi;
        private PanelRedondeado panelRedondeado5;
        private ReaLTaiizor.Controls.MaterialRadioButton rdbDolorPechoNo;
        private ReaLTaiizor.Controls.MaterialRadioButton rdbDolorPechoSi;
        private ReaLTaiizor.Controls.HopeNumeric numdolor;
        private ReaLTaiizor.Controls.HopeNumeric numtemperatura;
        private ReaLTaiizor.Controls.HopeNumeric numoxigeno;
        private ReaLTaiizor.Controls.HopeNumeric numevolucion;
        private ReaLTaiizor.Controls.PoisonComboBox cbmotivo;
        private ReaLTaiizor.Controls.PoisonComboBox cbestadomental;
        private ReaLTaiizor.Controls.PoisonComboBox cbmecanismo;
        private ReaLTaiizor.Controls.Button btncancelar;
        private ReaLTaiizor.Controls.Button btningresar;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label15;
        private Label label16;
        private ReaLTaiizor.Controls.BigTextBox txtdui;
        private ReaLTaiizor.Controls.PoisonDateTime dateedad;
        private Label label17;
        private ReaLTaiizor.Controls.PoisonComboBox cbgenero;
    }
}