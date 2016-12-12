namespace FrmMiniCalc
{
    partial class FrmIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIMC));
            this.CmdSalir = new System.Windows.Forms.Button();
            this.Txtaltura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdCaclular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIndicador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdSalir
            // 
            this.CmdSalir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("CmdSalir.Image")));
            this.CmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdSalir.Location = new System.Drawing.Point(232, 211);
            this.CmdSalir.Name = "CmdSalir";
            this.CmdSalir.Size = new System.Drawing.Size(100, 47);
            this.CmdSalir.TabIndex = 55;
            this.CmdSalir.Text = "&Cerrar";
            this.CmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdSalir.UseVisualStyleBackColor = true;
            this.CmdSalir.Click += new System.EventHandler(this.CmdSalir_Click);
            // 
            // Txtaltura
            // 
            this.Txtaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtaltura.Location = new System.Drawing.Point(163, 118);
            this.Txtaltura.Name = "Txtaltura";
            this.Txtaltura.Size = new System.Drawing.Size(96, 22);
            this.Txtaltura.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Altura (m) :";
            // 
            // TxtResultado
            // 
            this.TxtResultado.Enabled = false;
            this.TxtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResultado.Location = new System.Drawing.Point(163, 152);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(236, 22);
            this.TxtResultado.TabIndex = 60;
            // 
            // TxtPeso
            // 
            this.TxtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPeso.Location = new System.Drawing.Point(163, 84);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(96, 22);
            this.TxtPeso.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Resultado IMC :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "Peso  Kg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 63;
            this.label3.Text = "Calculo de IMC";
            // 
            // CmdCaclular
            // 
            this.CmdCaclular.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCaclular.Image = ((System.Drawing.Image)(resources.GetObject("CmdCaclular.Image")));
            this.CmdCaclular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCaclular.Location = new System.Drawing.Point(85, 211);
            this.CmdCaclular.Name = "CmdCaclular";
            this.CmdCaclular.Size = new System.Drawing.Size(100, 47);
            this.CmdCaclular.TabIndex = 64;
            this.CmdCaclular.Text = "&Calcular";
            this.CmdCaclular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCaclular.UseVisualStyleBackColor = true;
            this.CmdCaclular.Click += new System.EventHandler(this.CmdCaclular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(454, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 66;
            this.label6.Text = "NIVEL DE RIESGO";
            // 
            // TxtIndicador
            // 
            this.TxtIndicador.Enabled = false;
            this.TxtIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIndicador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TxtIndicador.Location = new System.Drawing.Point(457, 152);
            this.TxtIndicador.Name = "TxtIndicador";
            this.TxtIndicador.Size = new System.Drawing.Size(236, 38);
            this.TxtIndicador.TabIndex = 67;
            // 
            // FrmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 374);
            this.Controls.Add(this.TxtIndicador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmdCaclular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txtaltura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdSalir);
            this.Name = "FrmIMC";
            this.Text = "Calculo de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdSalir;
        private System.Windows.Forms.TextBox Txtaltura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CmdCaclular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtIndicador;
    }
}