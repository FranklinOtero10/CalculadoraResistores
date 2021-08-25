namespace CalculadoraResistores.GUI
{
    partial class CuBandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuBandas));
            this.cbbPrimera = new System.Windows.Forms.ComboBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbTolerancia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbMultiplicador = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbSegunda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbPrimera
            // 
            this.cbbPrimera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbPrimera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPrimera.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPrimera.FormattingEnabled = true;
            this.cbbPrimera.Items.AddRange(new object[] {
            "Negro (0)",
            "Marrón (1)",
            "Rojo (2)",
            "Naranja (3)",
            "Amarillo (4)",
            "Verde (5)",
            "Azul (6)",
            "Violeta (7)",
            "Gris (8)",
            "Blanco (9)"});
            this.cbbPrimera.Location = new System.Drawing.Point(6, 48);
            this.cbbPrimera.Name = "cbbPrimera";
            this.cbbPrimera.Size = new System.Drawing.Size(180, 25);
            this.cbbPrimera.TabIndex = 0;
            this.cbbPrimera.SelectedIndexChanged += new System.EventHandler(this.cbbPrimera_SelectedIndexChanged);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(394, 111);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(51, 53);
            this.btn2.TabIndex = 4;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(491, 111);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(51, 53);
            this.btn4.TabIndex = 5;
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(345, 111);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(51, 53);
            this.btn1.TabIndex = 6;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(443, 111);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(51, 53);
            this.btn3.TabIndex = 7;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbTolerancia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbMultiplicador);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbbSegunda);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbPrimera);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione los colores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tolerancia";
            // 
            // cbbTolerancia
            // 
            this.cbbTolerancia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTolerancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTolerancia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTolerancia.FormattingEnabled = true;
            this.cbbTolerancia.Items.AddRange(new object[] {
            "Marron ± 1%",
            "Rojo ± 2%",
            "Verde ± 5%",
            "Azul ± 0.25%",
            "Violeta ± 0.1%",
            "Gris ± 0.05%",
            "Oro ± 5%",
            "Plata ± 10%"});
            this.cbbTolerancia.Location = new System.Drawing.Point(6, 254);
            this.cbbTolerancia.Name = "cbbTolerancia";
            this.cbbTolerancia.Size = new System.Drawing.Size(180, 25);
            this.cbbTolerancia.TabIndex = 3;
            this.cbbTolerancia.SelectedIndexChanged += new System.EventHandler(this.cbbTolerancia_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Multiplicador (*)";
            // 
            // cbbMultiplicador
            // 
            this.cbbMultiplicador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbMultiplicador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMultiplicador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMultiplicador.FormattingEnabled = true;
            this.cbbMultiplicador.Items.AddRange(new object[] {
            "Negro (X1 Ω)",
            "Marrón (X10 Ω)",
            "Rojo (X100 Ω)",
            "Naranja (X1 kΩ)",
            "Amarillo (X10 kΩ)",
            "Verde (X100 kΩ)",
            "Azul (X1 MΩ)",
            "Violeta (X10 MΩ)",
            "Gris (X100 MΩ)",
            "Blanco (X1 GΩ)",
            "Oro (X0.1 Ω)",
            "Plata (X0.01 Ω)"});
            this.cbbMultiplicador.Location = new System.Drawing.Point(6, 185);
            this.cbbMultiplicador.Name = "cbbMultiplicador";
            this.cbbMultiplicador.Size = new System.Drawing.Size(180, 25);
            this.cbbMultiplicador.TabIndex = 2;
            this.cbbMultiplicador.SelectedIndexChanged += new System.EventHandler(this.cbbMultiplicador_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Segunda Banda";
            // 
            // cbbSegunda
            // 
            this.cbbSegunda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbSegunda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSegunda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSegunda.FormattingEnabled = true;
            this.cbbSegunda.Items.AddRange(new object[] {
            "Negro (0)",
            "Marrón (1)",
            "Rojo (2)",
            "Naranja (3)",
            "Amarillo (4)",
            "Verde (5)",
            "Azul (6)",
            "Violeta (7)",
            "Gris (8)",
            "Blanco (9)"});
            this.cbbSegunda.Location = new System.Drawing.Point(6, 114);
            this.cbbSegunda.Name = "cbbSegunda";
            this.cbbSegunda.Size = new System.Drawing.Size(180, 25);
            this.cbbSegunda.TabIndex = 1;
            this.cbbSegunda.SelectedIndexChanged += new System.EventHandler(this.cbbSegunda_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Primera Banda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "_________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "_________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(379, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Valor del Resistor";
            // 
            // txbValor
            // 
            this.txbValor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValor.Location = new System.Drawing.Point(337, 36);
            this.txbValor.Name = "txbValor";
            this.txbValor.ReadOnly = true;
            this.txbValor.Size = new System.Drawing.Size(213, 26);
            this.txbValor.TabIndex = 2;
            this.txbValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(488, 263);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 38);
            this.button6.TabIndex = 4;
            this.button6.Text = "Regresar al Menú ";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(394, 263);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(77, 38);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // CuBandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(628, 313);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CuBandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculadora para Cuatro Bandas";
            this.Load += new System.EventHandler(this.CuBandas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbPrimera;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbTolerancia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMultiplicador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbSegunda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnLimpiar;
    }
}