namespace GeniusTutorial
{
    partial class Form1
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
            this.pbAzul = new System.Windows.Forms.PictureBox();
            this.pbVermelho = new System.Windows.Forms.PictureBox();
            this.pbAmarelo = new System.Windows.Forms.PictureBox();
            this.pbVerde = new System.Windows.Forms.PictureBox();
            this.lblPontos = new System.Windows.Forms.Label();
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.mstArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).BeginInit();
            this.mstMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAzul
            // 
            this.pbAzul.BackColor = System.Drawing.Color.Blue;
            this.pbAzul.Enabled = false;
            this.pbAzul.Location = new System.Drawing.Point(60, 60);
            this.pbAzul.Name = "pbAzul";
            this.pbAzul.Size = new System.Drawing.Size(200, 200);
            this.pbAzul.TabIndex = 0;
            this.pbAzul.TabStop = false;
            this.pbAzul.Tag = "Azul";
            this.pbAzul.Click += new System.EventHandler(this.CliqueReferencia_Clik);
            // 
            // pbVermelho
            // 
            this.pbVermelho.BackColor = System.Drawing.Color.DarkRed;
            this.pbVermelho.Enabled = false;
            this.pbVermelho.Location = new System.Drawing.Point(320, 60);
            this.pbVermelho.Name = "pbVermelho";
            this.pbVermelho.Size = new System.Drawing.Size(200, 200);
            this.pbVermelho.TabIndex = 1;
            this.pbVermelho.TabStop = false;
            this.pbVermelho.Tag = "Vermelho";
            this.pbVermelho.Click += new System.EventHandler(this.CliqueReferencia_Clik);
            // 
            // pbAmarelo
            // 
            this.pbAmarelo.BackColor = System.Drawing.Color.Goldenrod;
            this.pbAmarelo.Enabled = false;
            this.pbAmarelo.Location = new System.Drawing.Point(60, 315);
            this.pbAmarelo.Name = "pbAmarelo";
            this.pbAmarelo.Size = new System.Drawing.Size(200, 200);
            this.pbAmarelo.TabIndex = 2;
            this.pbAmarelo.TabStop = false;
            this.pbAmarelo.Tag = "Amarelo";
            this.pbAmarelo.Click += new System.EventHandler(this.CliqueReferencia_Clik);
            // 
            // pbVerde
            // 
            this.pbVerde.BackColor = System.Drawing.Color.DarkGreen;
            this.pbVerde.Enabled = false;
            this.pbVerde.Location = new System.Drawing.Point(320, 315);
            this.pbVerde.Name = "pbVerde";
            this.pbVerde.Size = new System.Drawing.Size(200, 200);
            this.pbVerde.TabIndex = 3;
            this.pbVerde.TabStop = false;
            this.pbVerde.Click += new System.EventHandler(this.CliqueReferencia_Clik);
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPontos.Location = new System.Drawing.Point(66, 588);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(101, 29);
            this.lblPontos.TabIndex = 4;
            this.lblPontos.Text = "Pontos:";
            // 
            // mstMenu
            // 
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstArquivo});
            this.mstMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.Size = new System.Drawing.Size(584, 24);
            this.mstMenu.TabIndex = 5;
            this.mstMenu.Text = "menuStrip1";
            // 
            // mstArquivo
            // 
            this.mstArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mstArquivo.Name = "mstArquivo";
            this.mstArquivo.Size = new System.Drawing.Size(61, 20);
            this.mstArquivo.Text = "Arquivo";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.ControlBox = false;
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.pbVerde);
            this.Controls.Add(this.pbAmarelo);
            this.Controls.Add(this.pbVermelho);
            this.Controls.Add(this.pbAzul);
            this.Controls.Add(this.mstMenu);
            this.MainMenuStrip = this.mstMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo Genius";
            ((System.ComponentModel.ISupportInitialize)(this.pbAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).EndInit();
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAzul;
        private System.Windows.Forms.PictureBox pbVermelho;
        private System.Windows.Forms.PictureBox pbAmarelo;
        private System.Windows.Forms.PictureBox pbVerde;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.MenuStrip mstMenu;
        private System.Windows.Forms.ToolStripMenuItem mstArquivo;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

