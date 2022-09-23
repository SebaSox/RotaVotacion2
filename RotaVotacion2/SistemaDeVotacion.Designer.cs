
namespace RotaVotacion2
{
    partial class SistemaDeVotacion
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
            this.TxtClubesHabilitados = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nReunionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtNumReu = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CBoxPeriodos = new System.Windows.Forms.ToolStripComboBox();
            this.BtnHabilitar = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMocion = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.LblClubesHabilitados = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblNumReu = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtClubesHabilitados
            // 
            this.TxtClubesHabilitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClubesHabilitados.Location = new System.Drawing.Point(9, 170);
            this.TxtClubesHabilitados.Multiline = true;
            this.TxtClubesHabilitados.Name = "TxtClubesHabilitados";
            this.TxtClubesHabilitados.ReadOnly = true;
            this.TxtClubesHabilitados.Size = new System.Drawing.Size(612, 168);
            this.TxtClubesHabilitados.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nReunionToolStripMenuItem,
            this.BtnHabilitar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nReunionToolStripMenuItem
            // 
            this.nReunionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtNumReu,
            this.toolStripMenuItem1});
            this.nReunionToolStripMenuItem.Name = "nReunionToolStripMenuItem";
            this.nReunionToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.nReunionToolStripMenuItem.Text = "N° Reunion";
            // 
            // TxtNumReu
            // 
            this.TxtNumReu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TxtNumReu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtNumReu.Name = "TxtNumReu";
            this.TxtNumReu.Size = new System.Drawing.Size(150, 27);
            this.TxtNumReu.TextChanged += new System.EventHandler(this.TxtNumReu_TextChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CBoxPeriodos});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem1.Text = "Periodo:";
            // 
            // CBoxPeriodos
            // 
            this.CBoxPeriodos.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CBoxPeriodos.Name = "CBoxPeriodos";
            this.CBoxPeriodos.Size = new System.Drawing.Size(121, 28);
            // 
            // BtnHabilitar
            // 
            this.BtnHabilitar.Name = "BtnHabilitar";
            this.BtnHabilitar.Size = new System.Drawing.Size(117, 24);
            this.BtnHabilitar.Text = "Activar Clubes";
            this.BtnHabilitar.Click += new System.EventHandler(this.BtnHabilitar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clubes Habilitados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Periodo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mocion:";
            // 
            // TxtMocion
            // 
            this.TxtMocion.Location = new System.Drawing.Point(9, 372);
            this.TxtMocion.Multiline = true;
            this.TxtMocion.Name = "TxtMocion";
            this.TxtMocion.Size = new System.Drawing.Size(612, 83);
            this.TxtMocion.TabIndex = 5;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(476, 470);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(145, 43);
            this.BtnEnviar.TabIndex = 6;
            this.BtnEnviar.Text = "Mocionar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // LblClubesHabilitados
            // 
            this.LblClubesHabilitados.AutoSize = true;
            this.LblClubesHabilitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClubesHabilitados.Location = new System.Drawing.Point(200, 109);
            this.LblClubesHabilitados.Name = "LblClubesHabilitados";
            this.LblClubesHabilitados.Size = new System.Drawing.Size(19, 20);
            this.LblClubesHabilitados.TabIndex = 7;
            this.LblClubesHabilitados.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "N° Reunion:";
            // 
            // LblNumReu
            // 
            this.LblNumReu.AutoSize = true;
            this.LblNumReu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumReu.Location = new System.Drawing.Point(139, 73);
            this.LblNumReu.Name = "LblNumReu";
            this.LblNumReu.Size = new System.Drawing.Size(23, 20);
            this.LblNumReu.TabIndex = 9;
            this.LblNumReu.Text = "--";
            // 
            // SistemaDeVotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 533);
            this.Controls.Add(this.LblNumReu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblClubesHabilitados);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.TxtMocion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtClubesHabilitados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SistemaDeVotacion";
            this.Text = "Sistema de Votacion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtClubesHabilitados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nReunionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnHabilitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMocion;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Label LblClubesHabilitados;
        private System.Windows.Forms.ToolStripTextBox TxtNumReu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblNumReu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox CBoxPeriodos;
    }
}

