
namespace afd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maquinaDeDoce = new System.Windows.Forms.Button();
            this.elevador = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maquinaDeDoce
            // 
            this.maquinaDeDoce.BackColor = System.Drawing.Color.RoyalBlue;
            this.maquinaDeDoce.FlatAppearance.BorderSize = 0;
            this.maquinaDeDoce.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maquinaDeDoce.ForeColor = System.Drawing.Color.White;
            this.maquinaDeDoce.Location = new System.Drawing.Point(285, 204);
            this.maquinaDeDoce.Name = "maquinaDeDoce";
            this.maquinaDeDoce.Size = new System.Drawing.Size(289, 98);
            this.maquinaDeDoce.TabIndex = 0;
            this.maquinaDeDoce.Text = "MÁQUINA DE DOCE";
            this.maquinaDeDoce.UseVisualStyleBackColor = false;
            this.maquinaDeDoce.Click += new System.EventHandler(this.maquinaDeDoce_Click);
            // 
            // elevador
            // 
            this.elevador.BackColor = System.Drawing.Color.ForestGreen;
            this.elevador.FlatAppearance.BorderSize = 0;
            this.elevador.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.elevador.ForeColor = System.Drawing.Color.White;
            this.elevador.Location = new System.Drawing.Point(285, 308);
            this.elevador.Name = "elevador";
            this.elevador.Size = new System.Drawing.Size(289, 98);
            this.elevador.TabIndex = 1;
            this.elevador.Text = "ELEVADOR";
            this.elevador.UseVisualStyleBackColor = false;
            this.elevador.Click += new System.EventHandler(this.elevador_Click);
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.DarkRed;
            this.sair.FlatAppearance.BorderSize = 0;
            this.sair.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sair.ForeColor = System.Drawing.Color.White;
            this.sair.Location = new System.Drawing.Point(285, 412);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(289, 98);
            this.sair.TabIndex = 2;
            this.sair.Text = "SAIR";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(353, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "MENU\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(832, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.elevador);
            this.Controls.Add(this.maquinaDeDoce);
            this.Name = "Form1";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button maquinaDeDoce;
        private System.Windows.Forms.Button elevador;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Label label1;
    }
}

