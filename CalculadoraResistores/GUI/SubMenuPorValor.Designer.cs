namespace CalculadoraResistores.GUI
{
    partial class SubMenuPorValor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubMenuPorValor));
            this.label5 = new System.Windows.Forms.Label();
            this.btncuatro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btncinco = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Valor de 4 bandas";
            // 
            // btncuatro
            // 
            this.btncuatro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncuatro.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btncuatro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncuatro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btncuatro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btncuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncuatro.Image = ((System.Drawing.Image)(resources.GetObject("btncuatro.Image")));
            this.btncuatro.Location = new System.Drawing.Point(42, 92);
            this.btncuatro.Name = "btncuatro";
            this.btncuatro.Size = new System.Drawing.Size(118, 89);
            this.btncuatro.TabIndex = 34;
            this.btncuatro.UseVisualStyleBackColor = false;
            this.btncuatro.Click += new System.EventHandler(this.btncuatro_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Valor de 5 bandas";
            // 
            // btncinco
            // 
            this.btncinco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncinco.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btncinco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncinco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btncinco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btncinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncinco.Image = ((System.Drawing.Image)(resources.GetObject("btncinco.Image")));
            this.btncinco.Location = new System.Drawing.Point(270, 92);
            this.btncinco.Name = "btncinco";
            this.btncinco.Size = new System.Drawing.Size(118, 89);
            this.btncinco.TabIndex = 36;
            this.btncinco.UseVisualStyleBackColor = false;
            this.btncinco.Click += new System.EventHandler(this.btncinco_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "Conversión de Valor a Bandas de color";
            // 
            // SubMenuPorValor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 222);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncinco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncuatro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SubMenuPorValor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calcular Colores del Resistor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncuatro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncinco;
        private System.Windows.Forms.Label label2;
    }
}