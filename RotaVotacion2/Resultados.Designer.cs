
namespace RotaVotacion2
{
    partial class Resultados
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTotales = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnReanudar = new System.Windows.Forms.Button();
            this.BtnPausar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.ContadorDeVueltas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 238);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 238);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(991, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 238);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            // 
            // LblTotales
            // 
            this.LblTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotales.Location = new System.Drawing.Point(403, 28);
            this.LblTotales.Name = "LblTotales";
            this.LblTotales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblTotales.Size = new System.Drawing.Size(200, 142);
            this.LblTotales.TabIndex = 3;
            this.LblTotales.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(619, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 142);
            this.label6.TabIndex = 3;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(571, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 142);
            this.label4.TabIndex = 4;
            this.label4.Text = "|";
            // 
            // BtnReanudar
            // 
            this.BtnReanudar.Location = new System.Drawing.Point(792, 442);
            this.BtnReanudar.Name = "BtnReanudar";
            this.BtnReanudar.Size = new System.Drawing.Size(216, 96);
            this.BtnReanudar.TabIndex = 5;
            this.BtnReanudar.Text = "Reanudar";
            this.BtnReanudar.UseVisualStyleBackColor = true;
            this.BtnReanudar.Click += new System.EventHandler(this.BtnReanudar_Click);
            // 
            // BtnPausar
            // 
            this.BtnPausar.Location = new System.Drawing.Point(510, 441);
            this.BtnPausar.Name = "BtnPausar";
            this.BtnPausar.Size = new System.Drawing.Size(216, 96);
            this.BtnPausar.TabIndex = 6;
            this.BtnPausar.Text = "Pausar";
            this.BtnPausar.UseVisualStyleBackColor = true;
            this.BtnPausar.Click += new System.EventHandler(this.BtnPausar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(229, 441);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(216, 96);
            this.BtnCerrar.TabIndex = 7;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Temporizador
            // 
            this.Temporizador.Interval = 500;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // ContadorDeVueltas
            // 
            this.ContadorDeVueltas.AutoSize = true;
            this.ContadorDeVueltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContadorDeVueltas.Location = new System.Drawing.Point(11, 9);
            this.ContadorDeVueltas.Name = "ContadorDeVueltas";
            this.ContadorDeVueltas.Size = new System.Drawing.Size(14, 15);
            this.ContadorDeVueltas.TabIndex = 8;
            this.ContadorDeVueltas.Text = "0";
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 550);
            this.Controls.Add(this.ContadorDeVueltas);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnPausar);
            this.Controls.Add(this.BtnReanudar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblTotales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Resultados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnReanudar;
        private System.Windows.Forms.Button BtnPausar;
        private System.Windows.Forms.Button BtnCerrar;
        internal System.Windows.Forms.Label LblTotales;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.Label ContadorDeVueltas;
    }
}