
namespace Cronometro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCronometro = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.timerCronometro = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelCronometro
            // 
            this.labelCronometro.AutoSize = true;
            this.labelCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.labelCronometro.Location = new System.Drawing.Point(45, 53);
            this.labelCronometro.Name = "labelCronometro";
            this.labelCronometro.Size = new System.Drawing.Size(410, 73);
            this.labelCronometro.TabIndex = 0;
            this.labelCronometro.Text = "11:11:11.111";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(67, 167);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(74, 54);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(209, 167);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(74, 54);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnResetar
            // 
            this.btnResetar.Location = new System.Drawing.Point(351, 167);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(74, 54);
            this.btnResetar.TabIndex = 3;
            this.btnResetar.Text = "Resetar";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // timerCronometro
            // 
            this.timerCronometro.Enabled = true;
            this.timerCronometro.Tick += new System.EventHandler(this.timerCronometro_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 304);
            this.Controls.Add(this.btnResetar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.labelCronometro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCronometro;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.Timer timerCronometro;
    }
}

