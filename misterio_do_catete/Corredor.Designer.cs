﻿namespace misterio_do_catete
{
    partial class CorredorFase1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dialogo = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.PictureBox();
            this.som = new System.Windows.Forms.PictureBox();
            this.chavefase1 = new System.Windows.Forms.PictureBox();
            this.fechar = new System.Windows.Forms.PictureBox();
            this.caixadetexto = new System.Windows.Forms.PictureBox();
            this.quarto = new System.Windows.Forms.PictureBox();
            this.quarto4 = new System.Windows.Forms.PictureBox();
            this.quarto3 = new System.Windows.Forms.PictureBox();
            this.quarto2 = new System.Windows.Forms.PictureBox();
            this.continuarnojogo = new System.Windows.Forms.PictureBox();
            this.menuvoltar = new System.Windows.Forms.PictureBox();
            this.telaparavoltar = new System.Windows.Forms.PictureBox();
            this.deixarenabled = new System.Windows.Forms.PictureBox();
            this.senhorluiz = new System.Windows.Forms.PictureBox();
            this.sfx = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.som)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chavefase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caixadetexto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.continuarnojogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuvoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telaparavoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deixarenabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senhorluiz)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dialogo
            // 
            this.dialogo.BackColor = System.Drawing.Color.Silver;
            this.dialogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogo.ForeColor = System.Drawing.Color.Black;
            this.dialogo.Location = new System.Drawing.Point(134, 394);
            this.dialogo.Name = "dialogo";
            this.dialogo.Size = new System.Drawing.Size(506, 143);
            this.dialogo.TabIndex = 70;
            this.dialogo.Text = "label1";
            this.dialogo.Visible = false;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.Image = global::misterio_do_catete.Properties.Resources.casinha;
            this.menu.Location = new System.Drawing.Point(773, 12);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(45, 45);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu.TabIndex = 110;
            this.menu.TabStop = false;
            this.menu.Tag = "0";
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // som
            // 
            this.som.BackColor = System.Drawing.Color.Transparent;
            this.som.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.som.Image = global::misterio_do_catete.Properties.Resources.sonzinho;
            this.som.Location = new System.Drawing.Point(722, 12);
            this.som.Name = "som";
            this.som.Size = new System.Drawing.Size(45, 45);
            this.som.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.som.TabIndex = 109;
            this.som.TabStop = false;
            this.som.Tag = "0";
            this.som.Click += new System.EventHandler(this.som_Click);
            // 
            // chavefase1
            // 
            this.chavefase1.BackColor = System.Drawing.Color.Transparent;
            this.chavefase1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chavefase1.Image = global::misterio_do_catete.Properties.Resources.ChaveEP;
            this.chavefase1.Location = new System.Drawing.Point(772, 508);
            this.chavefase1.Name = "chavefase1";
            this.chavefase1.Size = new System.Drawing.Size(46, 41);
            this.chavefase1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chavefase1.TabIndex = 71;
            this.chavefase1.TabStop = false;
            this.chavefase1.Tag = "0";
            this.chavefase1.Visible = false;
            this.chavefase1.Click += new System.EventHandler(this.chavefase1_Click);
            // 
            // fechar
            // 
            this.fechar.BackColor = System.Drawing.Color.Silver;
            this.fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fechar.Image = global::misterio_do_catete.Properties.Resources.btnfechar;
            this.fechar.Location = new System.Drawing.Point(645, 479);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(52, 49);
            this.fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fechar.TabIndex = 69;
            this.fechar.TabStop = false;
            this.fechar.Visible = false;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // caixadetexto
            // 
            this.caixadetexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(184)))), ((int)(((byte)(58)))));
            this.caixadetexto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.caixadetexto.Image = global::misterio_do_catete.Properties.Resources.cadte;
            this.caixadetexto.Location = new System.Drawing.Point(110, 374);
            this.caixadetexto.Name = "caixadetexto";
            this.caixadetexto.Size = new System.Drawing.Size(608, 180);
            this.caixadetexto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caixadetexto.TabIndex = 68;
            this.caixadetexto.TabStop = false;
            this.caixadetexto.Visible = false;
            // 
            // quarto
            // 
            this.quarto.BackColor = System.Drawing.Color.Transparent;
            this.quarto.Location = new System.Drawing.Point(48, 97);
            this.quarto.Name = "quarto";
            this.quarto.Size = new System.Drawing.Size(156, 328);
            this.quarto.TabIndex = 6;
            this.quarto.TabStop = false;
            this.quarto.Tag = "0";
            this.quarto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EventClick);
            // 
            // quarto4
            // 
            this.quarto4.BackColor = System.Drawing.Color.Transparent;
            this.quarto4.Location = new System.Drawing.Point(647, 97);
            this.quarto4.Name = "quarto4";
            this.quarto4.Size = new System.Drawing.Size(150, 301);
            this.quarto4.TabIndex = 4;
            this.quarto4.TabStop = false;
            this.quarto4.Tag = "0";
            this.quarto4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EventClick);
            // 
            // quarto3
            // 
            this.quarto3.BackColor = System.Drawing.Color.Transparent;
            this.quarto3.Location = new System.Drawing.Point(473, 151);
            this.quarto3.Name = "quarto3";
            this.quarto3.Size = new System.Drawing.Size(105, 217);
            this.quarto3.TabIndex = 3;
            this.quarto3.TabStop = false;
            this.quarto3.Tag = "0";
            this.quarto3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EventClick);
            // 
            // quarto2
            // 
            this.quarto2.BackColor = System.Drawing.Color.Transparent;
            this.quarto2.Location = new System.Drawing.Point(282, 151);
            this.quarto2.Name = "quarto2";
            this.quarto2.Size = new System.Drawing.Size(115, 224);
            this.quarto2.TabIndex = 2;
            this.quarto2.TabStop = false;
            this.quarto2.Tag = "0";
            this.quarto2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EventClick);
            // 
            // continuarnojogo
            // 
            this.continuarnojogo.BackColor = System.Drawing.Color.Transparent;
            this.continuarnojogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.continuarnojogo.Location = new System.Drawing.Point(420, 376);
            this.continuarnojogo.Name = "continuarnojogo";
            this.continuarnojogo.Size = new System.Drawing.Size(266, 66);
            this.continuarnojogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.continuarnojogo.TabIndex = 118;
            this.continuarnojogo.TabStop = false;
            this.continuarnojogo.Tag = "0";
            this.continuarnojogo.Visible = false;
            this.continuarnojogo.Click += new System.EventHandler(this.continuarnojogo_Click);
            // 
            // menuvoltar
            // 
            this.menuvoltar.BackColor = System.Drawing.Color.Transparent;
            this.menuvoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuvoltar.Location = new System.Drawing.Point(148, 376);
            this.menuvoltar.Name = "menuvoltar";
            this.menuvoltar.Size = new System.Drawing.Size(266, 66);
            this.menuvoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuvoltar.TabIndex = 117;
            this.menuvoltar.TabStop = false;
            this.menuvoltar.Tag = "0";
            this.menuvoltar.Visible = false;
            this.menuvoltar.Click += new System.EventHandler(this.menuvoltar_Click);
            // 
            // telaparavoltar
            // 
            this.telaparavoltar.BackColor = System.Drawing.Color.Transparent;
            this.telaparavoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.telaparavoltar.Enabled = false;
            this.telaparavoltar.Image = global::misterio_do_catete.Properties.Resources.certeza;
            this.telaparavoltar.Location = new System.Drawing.Point(89, 74);
            this.telaparavoltar.Name = "telaparavoltar";
            this.telaparavoltar.Size = new System.Drawing.Size(656, 412);
            this.telaparavoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.telaparavoltar.TabIndex = 116;
            this.telaparavoltar.TabStop = false;
            this.telaparavoltar.Tag = "";
            this.telaparavoltar.Visible = false;
            // 
            // deixarenabled
            // 
            this.deixarenabled.BackColor = System.Drawing.Color.Transparent;
            this.deixarenabled.Location = new System.Drawing.Point(-8, -20);
            this.deixarenabled.Name = "deixarenabled";
            this.deixarenabled.Size = new System.Drawing.Size(850, 600);
            this.deixarenabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deixarenabled.TabIndex = 132;
            this.deixarenabled.TabStop = false;
            this.deixarenabled.Tag = "";
            this.deixarenabled.Visible = false;
            // 
            // senhorluiz
            // 
            this.senhorluiz.BackColor = System.Drawing.Color.Transparent;
            this.senhorluiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.senhorluiz.Enabled = false;
            this.senhorluiz.Image = global::misterio_do_catete.Properties.Resources.luiz_e;
            this.senhorluiz.Location = new System.Drawing.Point(89, 117);
            this.senhorluiz.Name = "senhorluiz";
            this.senhorluiz.Size = new System.Drawing.Size(267, 498);
            this.senhorluiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.senhorluiz.TabIndex = 133;
            this.senhorluiz.TabStop = false;
            this.senhorluiz.Visible = false;
            // 
            // sfx
            // 
            this.sfx.Interval = 2100;
            this.sfx.Tick += new System.EventHandler(this.Timer_Effects);
            // 
            // CorredorFase1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::misterio_do_catete.Properties.Resources.corredore;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.telaparavoltar);
            this.Controls.Add(this.dialogo);
            this.Controls.Add(this.caixadetexto);
            this.Controls.Add(this.senhorluiz);
            this.Controls.Add(this.continuarnojogo);
            this.Controls.Add(this.menuvoltar);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.som);
            this.Controls.Add(this.chavefase1);
            this.Controls.Add(this.deixarenabled);
            this.Controls.Add(this.quarto);
            this.Controls.Add(this.quarto4);
            this.Controls.Add(this.quarto3);
            this.Controls.Add(this.quarto2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Bisque;
            this.Name = "CorredorFase1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corredor";
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.som)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chavefase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caixadetexto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.continuarnojogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuvoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telaparavoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deixarenabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senhorluiz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox quarto2;
        private System.Windows.Forms.PictureBox quarto3;
        private System.Windows.Forms.PictureBox quarto4;
        private System.Windows.Forms.PictureBox quarto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox fechar;
        private System.Windows.Forms.PictureBox caixadetexto;
        private System.Windows.Forms.Label dialogo;
        private System.Windows.Forms.PictureBox chavefase1;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.PictureBox som;
        private System.Windows.Forms.PictureBox continuarnojogo;
        private System.Windows.Forms.PictureBox menuvoltar;
        private System.Windows.Forms.PictureBox telaparavoltar;
        private System.Windows.Forms.PictureBox deixarenabled;
        private System.Windows.Forms.PictureBox senhorluiz;
        private System.Windows.Forms.Timer sfx;
    }
}