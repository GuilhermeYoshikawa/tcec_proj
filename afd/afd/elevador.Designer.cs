
namespace afd
{
    partial class elevador
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
            this.btnTerreo = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnPrimeiroAndar = new System.Windows.Forms.Button();
            this.btnSegundoAndar = new System.Windows.Forms.Button();
            this.btnTerceiroAndar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAndarAtual = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblAndar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.seta_elevador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seta_elevador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTerreo
            // 
            this.btnTerreo.BackColor = System.Drawing.SystemColors.Control;
            this.btnTerreo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTerreo.Location = new System.Drawing.Point(169, 342);
            this.btnTerreo.Name = "btnTerreo";
            this.btnTerreo.Size = new System.Drawing.Size(60, 60);
            this.btnTerreo.TabIndex = 0;
            this.btnTerreo.Text = "T";
            this.btnTerreo.UseVisualStyleBackColor = false;
            this.btnTerreo.Click += new System.EventHandler(this.btnTerreo_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.SystemColors.Control;
            this.btnAbrir.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbrir.Location = new System.Drawing.Point(169, 418);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(60, 60);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "<>";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.Control;
            this.btnFechar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.Location = new System.Drawing.Point(241, 418);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(60, 60);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "><";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnPrimeiroAndar
            // 
            this.btnPrimeiroAndar.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrimeiroAndar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrimeiroAndar.Location = new System.Drawing.Point(241, 342);
            this.btnPrimeiroAndar.Name = "btnPrimeiroAndar";
            this.btnPrimeiroAndar.Size = new System.Drawing.Size(60, 60);
            this.btnPrimeiroAndar.TabIndex = 3;
            this.btnPrimeiroAndar.Text = "1";
            this.btnPrimeiroAndar.UseVisualStyleBackColor = false;
            this.btnPrimeiroAndar.Click += new System.EventHandler(this.btnPrimeiroAndar_Click);
            // 
            // btnSegundoAndar
            // 
            this.btnSegundoAndar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSegundoAndar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSegundoAndar.Location = new System.Drawing.Point(169, 264);
            this.btnSegundoAndar.Name = "btnSegundoAndar";
            this.btnSegundoAndar.Size = new System.Drawing.Size(60, 60);
            this.btnSegundoAndar.TabIndex = 4;
            this.btnSegundoAndar.Text = "2";
            this.btnSegundoAndar.UseVisualStyleBackColor = false;
            this.btnSegundoAndar.Click += new System.EventHandler(this.btnSegundoAndar_Click);
            // 
            // btnTerceiroAndar
            // 
            this.btnTerceiroAndar.BackColor = System.Drawing.SystemColors.Control;
            this.btnTerceiroAndar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTerceiroAndar.Location = new System.Drawing.Point(241, 264);
            this.btnTerceiroAndar.Name = "btnTerceiroAndar";
            this.btnTerceiroAndar.Size = new System.Drawing.Size(60, 60);
            this.btnTerceiroAndar.TabIndex = 5;
            this.btnTerceiroAndar.Text = "3";
            this.btnTerceiroAndar.UseVisualStyleBackColor = false;
            this.btnTerceiroAndar.Click += new System.EventHandler(this.btnTerceiroAndar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::afd.Properties.Resources.porta_aberta;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(509, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 496);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblAndarAtual
            // 
            this.lblAndarAtual.AutoSize = true;
            this.lblAndarAtual.BackColor = System.Drawing.Color.Black;
            this.lblAndarAtual.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAndarAtual.ForeColor = System.Drawing.Color.Lime;
            this.lblAndarAtual.Location = new System.Drawing.Point(671, 70);
            this.lblAndarAtual.Name = "lblAndarAtual";
            this.lblAndarAtual.Size = new System.Drawing.Size(27, 35);
            this.lblAndarAtual.TabIndex = 8;
            this.lblAndarAtual.Text = "0";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfirmar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.Location = new System.Drawing.Point(169, 508);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(132, 60);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(153, 155);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(167, 73);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // lblAndar
            // 
            this.lblAndar.AutoSize = true;
            this.lblAndar.BackColor = System.Drawing.Color.Black;
            this.lblAndar.Font = new System.Drawing.Font("Agency FB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAndar.ForeColor = System.Drawing.Color.Lime;
            this.lblAndar.Location = new System.Drawing.Point(217, 163);
            this.lblAndar.Name = "lblAndar";
            this.lblAndar.Size = new System.Drawing.Size(46, 57);
            this.lblAndar.TabIndex = 11;
            this.lblAndar.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Silver;
            this.pictureBox4.Location = new System.Drawing.Point(112, 124);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(249, 492);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.Location = new System.Drawing.Point(635, 66);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(110, 40);
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // seta_elevador
            // 
            this.seta_elevador.BackColor = System.Drawing.Color.Black;
            this.seta_elevador.BackgroundImage = global::afd.Properties.Resources.seta_subindo;
            this.seta_elevador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seta_elevador.Location = new System.Drawing.Point(659, 70);
            this.seta_elevador.Name = "seta_elevador";
            this.seta_elevador.Size = new System.Drawing.Size(80, 36);
            this.seta_elevador.TabIndex = 15;
            this.seta_elevador.TabStop = false;
            // 
            // elevador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(982, 710);
            this.Controls.Add(this.lblAndarAtual);
            this.Controls.Add(this.seta_elevador);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblAndar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTerceiroAndar);
            this.Controls.Add(this.btnSegundoAndar);
            this.Controls.Add(this.btnPrimeiroAndar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnTerreo);
            this.Controls.Add(this.pictureBox4);
            this.Name = "elevador";
            this.Text = "Elevador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.elevador_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seta_elevador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerreo;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnPrimeiroAndar;
        private System.Windows.Forms.Button btnSegundoAndar;
        private System.Windows.Forms.Button btnTerceiroAndar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAndarAtual;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblAndar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox seta_elevador;
    }
}