
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
            this.LblNegativo = new System.Windows.Forms.Label();
            this.LblAbstencion = new System.Windows.Forms.Label();
            this.LblPositivo = new System.Windows.Forms.Label();
            this.LblTotales = new System.Windows.Forms.Label();
            this.LblClubsYaVotados = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnReanudar = new System.Windows.Forms.Button();
            this.BtnPausar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.ContadorDeVueltas = new System.Windows.Forms.Label();
            this.LblMocion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblNegativo
            // 
            this.LblNegativo.AutoSize = true;
            this.LblNegativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNegativo.ForeColor = System.Drawing.Color.Red;
            this.LblNegativo.Location = new System.Drawing.Point(11, 201);
            this.LblNegativo.Name = "LblNegativo";
            this.LblNegativo.Size = new System.Drawing.Size(216, 238);
            this.LblNegativo.TabIndex = 0;
            this.LblNegativo.Text = "0";
            // 
            // LblAbstencion
            // 
            this.LblAbstencion.AutoSize = true;
            this.LblAbstencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAbstencion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblAbstencion.Location = new System.Drawing.Point(510, 201);
            this.LblAbstencion.Name = "LblAbstencion";
            this.LblAbstencion.Size = new System.Drawing.Size(216, 238);
            this.LblAbstencion.TabIndex = 1;
            this.LblAbstencion.Text = "0";
            // 
            // LblPositivo
            // 
            this.LblPositivo.AutoSize = true;
            this.LblPositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPositivo.ForeColor = System.Drawing.Color.Lime;
            this.LblPositivo.Location = new System.Drawing.Point(991, 201);
            this.LblPositivo.Name = "LblPositivo";
            this.LblPositivo.Size = new System.Drawing.Size(216, 238);
            this.LblPositivo.TabIndex = 2;
            this.LblPositivo.Text = "0";
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
            // LblClubsYaVotados
            // 
            this.LblClubsYaVotados.AutoSize = true;
            this.LblClubsYaVotados.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClubsYaVotados.Location = new System.Drawing.Point(619, 28);
            this.LblClubsYaVotados.Name = "LblClubsYaVotados";
            this.LblClubsYaVotados.Size = new System.Drawing.Size(130, 142);
            this.LblClubsYaVotados.TabIndex = 3;
            this.LblClubsYaVotados.Text = "0";
            this.LblClubsYaVotados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.BtnReanudar.Location = new System.Drawing.Point(792, 541);
            this.BtnReanudar.Name = "BtnReanudar";
            this.BtnReanudar.Size = new System.Drawing.Size(216, 96);
            this.BtnReanudar.TabIndex = 5;
            this.BtnReanudar.Text = "Reanudar";
            this.BtnReanudar.UseVisualStyleBackColor = true;
            this.BtnReanudar.Click += new System.EventHandler(this.BtnReanudar_Click);
            // 
            // BtnPausar
            // 
            this.BtnPausar.Location = new System.Drawing.Point(510, 540);
            this.BtnPausar.Name = "BtnPausar";
            this.BtnPausar.Size = new System.Drawing.Size(216, 96);
            this.BtnPausar.TabIndex = 6;
            this.BtnPausar.Text = "Pausar";
            this.BtnPausar.UseVisualStyleBackColor = true;
            this.BtnPausar.Click += new System.EventHandler(this.BtnPausar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(229, 540);
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
            // LblMocion
            // 
            this.LblMocion.Enabled = false;
            this.LblMocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMocion.Location = new System.Drawing.Point(335, 443);
            this.LblMocion.Multiline = true;
            this.LblMocion.Name = "LblMocion";
            this.LblMocion.ReadOnly = true;
            this.LblMocion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LblMocion.Size = new System.Drawing.Size(574, 76);
            this.LblMocion.TabIndex = 9;
            this.LblMocion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 648);
            this.Controls.Add(this.LblMocion);
            this.Controls.Add(this.ContadorDeVueltas);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnPausar);
            this.Controls.Add(this.BtnReanudar);
            this.Controls.Add(this.LblClubsYaVotados);
            this.Controls.Add(this.LblTotales);
            this.Controls.Add(this.LblPositivo);
            this.Controls.Add(this.LblAbstencion);
            this.Controls.Add(this.LblNegativo);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Resultados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNegativo;
        private System.Windows.Forms.Label LblAbstencion;
        private System.Windows.Forms.Label LblPositivo;
        private System.Windows.Forms.Label LblClubsYaVotados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnReanudar;
        private System.Windows.Forms.Button BtnPausar;
        private System.Windows.Forms.Button BtnCerrar;
        internal System.Windows.Forms.Label LblTotales;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.Label ContadorDeVueltas;
        private System.Windows.Forms.TextBox LblMocion;
    }
}