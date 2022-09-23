
namespace RotaVotacion2
{
    partial class HabilitarClubes
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
            this.Clubes_Habilitados = new System.Windows.Forms.CheckedListBox();
            this.BtnReiniciar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clubes_Habilitados
            // 
            this.Clubes_Habilitados.FormattingEnabled = true;
            this.Clubes_Habilitados.Location = new System.Drawing.Point(13, 30);
            this.Clubes_Habilitados.MultiColumn = true;
            this.Clubes_Habilitados.Name = "Clubes_Habilitados";
            this.Clubes_Habilitados.Size = new System.Drawing.Size(552, 497);
            this.Clubes_Habilitados.TabIndex = 0;
            // 
            // BtnReiniciar
            // 
            this.BtnReiniciar.Location = new System.Drawing.Point(572, 249);
            this.BtnReiniciar.Name = "BtnReiniciar";
            this.BtnReiniciar.Size = new System.Drawing.Size(139, 102);
            this.BtnReiniciar.TabIndex = 1;
            this.BtnReiniciar.Text = "Reiniciar";
            this.BtnReiniciar.UseVisualStyleBackColor = true;
            this.BtnReiniciar.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(572, 95);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(139, 102);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(572, 394);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(139, 102);
            this.BtnConfirmar.TabIndex = 3;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // HabilitarClubes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 546);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnReiniciar);
            this.Controls.Add(this.Clubes_Habilitados);
            this.Name = "HabilitarClubes";
            this.Text = "HabiliarClubes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Clubes_Habilitados;
        private System.Windows.Forms.Button BtnReiniciar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnConfirmar;
    }
}