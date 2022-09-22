namespace TP1LAB2_2
{
    partial class FormInicio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudLargo = new System.Windows.Forms.NumericUpDown();
            this.nudAncho = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudGatos = new System.Windows.Forms.NumericUpDown();
            this.nudRatones = new System.Windows.Forms.NumericUpDown();
            this.nudQuesos = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbIsla2 = new System.Windows.Forms.RadioButton();
            this.rbIsla1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAncho)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRatones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuesos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.nudLargo);
            this.panel1.Controls.Add(this.nudAncho);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // nudLargo
            // 
            this.nudLargo.BackColor = System.Drawing.SystemColors.Highlight;
            this.nudLargo.ForeColor = System.Drawing.Color.Black;
            this.nudLargo.Location = new System.Drawing.Point(141, 69);
            this.nudLargo.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudLargo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLargo.Name = "nudLargo";
            this.nudLargo.Size = new System.Drawing.Size(45, 20);
            this.nudLargo.TabIndex = 4;
            this.nudLargo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAncho
            // 
            this.nudAncho.BackColor = System.Drawing.SystemColors.Highlight;
            this.nudAncho.ForeColor = System.Drawing.Color.Black;
            this.nudAncho.Location = new System.Drawing.Point(141, 43);
            this.nudAncho.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAncho.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAncho.Name = "nudAncho";
            this.nudAncho.Size = new System.Drawing.Size(45, 20);
            this.nudAncho.TabIndex = 3;
            this.nudAncho.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAncho.ValueChanged += new System.EventHandler(this.nudAncho_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Largo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ancho:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sleccione el tamaño de la isla:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.nudGatos);
            this.panel2.Controls.Add(this.nudRatones);
            this.panel2.Controls.Add(this.nudQuesos);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rbIsla2);
            this.panel2.Controls.Add(this.rbIsla1);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 137);
            this.panel2.TabIndex = 1;
            // 
            // nudGatos
            // 
            this.nudGatos.BackColor = System.Drawing.SystemColors.Highlight;
            this.nudGatos.Enabled = false;
            this.nudGatos.ForeColor = System.Drawing.Color.Black;
            this.nudGatos.Location = new System.Drawing.Point(141, 111);
            this.nudGatos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGatos.Name = "nudGatos";
            this.nudGatos.Size = new System.Drawing.Size(45, 20);
            this.nudGatos.TabIndex = 7;
            this.nudGatos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudRatones
            // 
            this.nudRatones.BackColor = System.Drawing.SystemColors.Highlight;
            this.nudRatones.ForeColor = System.Drawing.Color.Black;
            this.nudRatones.Location = new System.Drawing.Point(141, 80);
            this.nudRatones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRatones.Name = "nudRatones";
            this.nudRatones.Size = new System.Drawing.Size(45, 20);
            this.nudRatones.TabIndex = 6;
            this.nudRatones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudQuesos
            // 
            this.nudQuesos.BackColor = System.Drawing.SystemColors.Highlight;
            this.nudQuesos.ForeColor = System.Drawing.Color.Black;
            this.nudQuesos.Location = new System.Drawing.Point(141, 48);
            this.nudQuesos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuesos.Name = "nudQuesos";
            this.nudQuesos.Size = new System.Drawing.Size(45, 20);
            this.nudQuesos.TabIndex = 5;
            this.nudQuesos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cantidad de Gatos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad de Ratones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cantidad de Quesos";
            // 
            // rbIsla2
            // 
            this.rbIsla2.AutoSize = true;
            this.rbIsla2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbIsla2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbIsla2.ForeColor = System.Drawing.Color.Black;
            this.rbIsla2.Location = new System.Drawing.Point(113, 14);
            this.rbIsla2.Name = "rbIsla2";
            this.rbIsla2.Size = new System.Drawing.Size(49, 17);
            this.rbIsla2.TabIndex = 1;
            this.rbIsla2.TabStop = true;
            this.rbIsla2.Text = "Isla 2";
            this.rbIsla2.UseVisualStyleBackColor = false;
            this.rbIsla2.CheckedChanged += new System.EventHandler(this.rbIsla2_CheckedChanged);
            // 
            // rbIsla1
            // 
            this.rbIsla1.AutoSize = true;
            this.rbIsla1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbIsla1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbIsla1.ForeColor = System.Drawing.Color.Black;
            this.rbIsla1.Location = new System.Drawing.Point(16, 14);
            this.rbIsla1.Name = "rbIsla1";
            this.rbIsla1.Size = new System.Drawing.Size(49, 17);
            this.rbIsla1.TabIndex = 0;
            this.rbIsla1.TabStop = true;
            this.rbIsla1.Text = "Isla 1";
            this.rbIsla1.UseVisualStyleBackColor = false;
            this.rbIsla1.CheckedChanged += new System.EventHandler(this.rbIsla1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(136, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(222, 304);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(1000, 1000);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TransparencyKey = System.Drawing.Color.White;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAncho)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRatones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuesos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.NumericUpDown nudLargo;
        public System.Windows.Forms.NumericUpDown nudAncho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.NumericUpDown nudGatos;
        public System.Windows.Forms.NumericUpDown nudRatones;
        public System.Windows.Forms.NumericUpDown nudQuesos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RadioButton rbIsla2;
        public System.Windows.Forms.RadioButton rbIsla1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}