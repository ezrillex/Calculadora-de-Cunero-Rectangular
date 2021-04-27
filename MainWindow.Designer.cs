
namespace Calculatora
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.numericDiametro = new System.Windows.Forms.NumericUpDown();
            this.numericTorqueMaximoTransimitr = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.bAnalizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbL = new System.Windows.Forms.TextBox();
            this.tbr = new System.Windows.Forms.TextBox();
            this.tbKt = new System.Windows.Forms.TextBox();
            this.tbKts = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUltimoTension = new System.Windows.Forms.NumericUpDown();
            this.numericFluencia = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericFactorSeguridad = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbResultadoAplastamiento = new System.Windows.Forms.TextBox();
            this.tbResultadoCortante = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbAncho = new System.Windows.Forms.TextBox();
            this.tbAlto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiametro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTorqueMaximoTransimitr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUltimoTension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFluencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFactorSeguridad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diametro (Milimetros)";
            // 
            // numericDiametro
            // 
            this.numericDiametro.DecimalPlaces = 2;
            this.numericDiametro.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDiametro.Location = new System.Drawing.Point(12, 100);
            this.numericDiametro.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.numericDiametro.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericDiametro.Name = "numericDiametro";
            this.numericDiametro.Size = new System.Drawing.Size(284, 45);
            this.numericDiametro.TabIndex = 1;
            this.numericDiametro.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numericTorqueMaximoTransimitr
            // 
            this.numericTorqueMaximoTransimitr.DecimalPlaces = 2;
            this.numericTorqueMaximoTransimitr.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTorqueMaximoTransimitr.Location = new System.Drawing.Point(12, 280);
            this.numericTorqueMaximoTransimitr.Name = "numericTorqueMaximoTransimitr";
            this.numericTorqueMaximoTransimitr.Size = new System.Drawing.Size(351, 45);
            this.numericTorqueMaximoTransimitr.TabIndex = 2;
            this.numericTorqueMaximoTransimitr.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(684, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Torque Maximo a Transmitir (Newtons por milimetro)";
            // 
            // bAnalizar
            // 
            this.bAnalizar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bAnalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAnalizar.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnalizar.Location = new System.Drawing.Point(12, 331);
            this.bAnalizar.Name = "bAnalizar";
            this.bAnalizar.Size = new System.Drawing.Size(230, 48);
            this.bAnalizar.TabIndex = 4;
            this.bAnalizar.Text = "Calcular";
            this.bAnalizar.UseVisualStyleBackColor = false;
            this.bAnalizar.Click += new System.EventHandler(this.bAnalizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "Parametros Recomendados:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "L:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "r:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 38);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kt:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 579);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 38);
            this.label8.TabIndex = 10;
            this.label8.Text = "Kts:";
            // 
            // tbL
            // 
            this.tbL.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbL.Location = new System.Drawing.Point(87, 423);
            this.tbL.Name = "tbL";
            this.tbL.Size = new System.Drawing.Size(209, 45);
            this.tbL.TabIndex = 11;
            // 
            // tbr
            // 
            this.tbr.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbr.Location = new System.Drawing.Point(87, 474);
            this.tbr.Name = "tbr";
            this.tbr.Size = new System.Drawing.Size(209, 45);
            this.tbr.TabIndex = 12;
            // 
            // tbKt
            // 
            this.tbKt.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKt.Location = new System.Drawing.Point(87, 525);
            this.tbKt.Name = "tbKt";
            this.tbKt.Size = new System.Drawing.Size(209, 45);
            this.tbKt.TabIndex = 13;
            // 
            // tbKts
            // 
            this.tbKts.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKts.Location = new System.Drawing.Point(87, 576);
            this.tbKts.Name = "tbKts";
            this.tbKts.Size = new System.Drawing.Size(209, 45);
            this.tbKts.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(479, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(336, 38);
            this.label9.TabIndex = 15;
            this.label9.Text = "Propiedades del Material:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(379, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(590, 38);
            this.label10.TabIndex = 16;
            this.label10.Text = "Esfuerzo Ultimo a la Tension (Mega Pascales):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(379, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(494, 38);
            this.label11.TabIndex = 17;
            this.label11.Text = "Esfuerzo de Fluencia (Mega Pascales):";
            // 
            // numericUltimoTension
            // 
            this.numericUltimoTension.DecimalPlaces = 2;
            this.numericUltimoTension.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUltimoTension.Location = new System.Drawing.Point(386, 189);
            this.numericUltimoTension.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUltimoTension.Name = "numericUltimoTension";
            this.numericUltimoTension.Size = new System.Drawing.Size(583, 45);
            this.numericUltimoTension.TabIndex = 18;
            this.numericUltimoTension.Value = new decimal(new int[] {
            420,
            0,
            0,
            0});
            // 
            // numericFluencia
            // 
            this.numericFluencia.DecimalPlaces = 2;
            this.numericFluencia.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericFluencia.Location = new System.Drawing.Point(386, 96);
            this.numericFluencia.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericFluencia.Name = "numericFluencia";
            this.numericFluencia.Size = new System.Drawing.Size(583, 45);
            this.numericFluencia.TabIndex = 19;
            this.numericFluencia.Value = new decimal(new int[] {
            352,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(284, 38);
            this.label12.TabIndex = 20;
            this.label12.Text = "Factor de Seguridad:";
            // 
            // numericFactorSeguridad
            // 
            this.numericFactorSeguridad.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericFactorSeguridad.Location = new System.Drawing.Point(12, 189);
            this.numericFactorSeguridad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericFactorSeguridad.Name = "numericFactorSeguridad";
            this.numericFactorSeguridad.Size = new System.Drawing.Size(284, 45);
            this.numericFactorSeguridad.TabIndex = 21;
            this.numericFactorSeguridad.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(379, 430);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(481, 38);
            this.label13.TabIndex = 22;
            this.label13.Text = "Calculado con Aplastamiento Maximo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(379, 528);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(414, 38);
            this.label14.TabIndex = 23;
            this.label14.Text = "Calculado con Cortante Maxima:";
            // 
            // tbResultadoAplastamiento
            // 
            this.tbResultadoAplastamiento.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultadoAplastamiento.Location = new System.Drawing.Point(386, 474);
            this.tbResultadoAplastamiento.Name = "tbResultadoAplastamiento";
            this.tbResultadoAplastamiento.Size = new System.Drawing.Size(584, 45);
            this.tbResultadoAplastamiento.TabIndex = 24;
            // 
            // tbResultadoCortante
            // 
            this.tbResultadoCortante.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultadoCortante.Location = new System.Drawing.Point(386, 576);
            this.tbResultadoCortante.Name = "tbResultadoCortante";
            this.tbResultadoCortante.Size = new System.Drawing.Size(584, 45);
            this.tbResultadoCortante.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 24);
            this.button1.TabIndex = 26;
            this.button1.Text = "Acerca De";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(379, 382);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 38);
            this.label15.TabIndex = 27;
            this.label15.Text = "Ancho:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(686, 382);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 38);
            this.label16.TabIndex = 28;
            this.label16.Text = "Alto:";
            // 
            // tbAncho
            // 
            this.tbAncho.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAncho.Location = new System.Drawing.Point(482, 379);
            this.tbAncho.Name = "tbAncho";
            this.tbAncho.Size = new System.Drawing.Size(198, 45);
            this.tbAncho.TabIndex = 29;
            // 
            // tbAlto
            // 
            this.tbAlto.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlto.Location = new System.Drawing.Point(771, 379);
            this.tbAlto.Name = "tbAlto";
            this.tbAlto.Size = new System.Drawing.Size(199, 45);
            this.tbAlto.TabIndex = 30;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 633);
            this.Controls.Add(this.tbAlto);
            this.Controls.Add(this.tbAncho);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbResultadoCortante);
            this.Controls.Add(this.tbResultadoAplastamiento);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numericFactorSeguridad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericFluencia);
            this.Controls.Add(this.numericUltimoTension);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbKts);
            this.Controls.Add(this.tbKt);
            this.Controls.Add(this.tbr);
            this.Controls.Add(this.tbL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bAnalizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericTorqueMaximoTransimitr);
            this.Controls.Add(this.numericDiametro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Calculadora de Cuñero Rectangular";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericDiametro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTorqueMaximoTransimitr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUltimoTension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFluencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFactorSeguridad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericDiametro;
        private System.Windows.Forms.NumericUpDown numericTorqueMaximoTransimitr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAnalizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbL;
        private System.Windows.Forms.TextBox tbr;
        private System.Windows.Forms.TextBox tbKt;
        private System.Windows.Forms.TextBox tbKts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUltimoTension;
        private System.Windows.Forms.NumericUpDown numericFluencia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericFactorSeguridad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbResultadoAplastamiento;
        private System.Windows.Forms.TextBox tbResultadoCortante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbAncho;
        private System.Windows.Forms.TextBox tbAlto;
    }
}

