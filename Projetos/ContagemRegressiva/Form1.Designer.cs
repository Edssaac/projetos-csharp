
namespace ContagemRegressiva
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
            this.comboMinutos = new System.Windows.Forms.ComboBox();
            this.comboSegundos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTempo = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // comboMinutos
            // 
            this.comboMinutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMinutos.FormattingEnabled = true;
            this.comboMinutos.Location = new System.Drawing.Point(11, 48);
            this.comboMinutos.Name = "comboMinutos";
            this.comboMinutos.Size = new System.Drawing.Size(165, 21);
            this.comboMinutos.TabIndex = 0;
            // 
            // comboSegundos
            // 
            this.comboSegundos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSegundos.FormattingEnabled = true;
            this.comboSegundos.Location = new System.Drawing.Point(192, 48);
            this.comboSegundos.Name = "comboSegundos";
            this.comboSegundos.Size = new System.Drawing.Size(166, 21);
            this.comboSegundos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minutos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(188, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Segundos:";
            // 
            // labelTempo
            // 
            this.labelTempo.AutoSize = true;
            this.labelTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.labelTempo.Location = new System.Drawing.Point(83, 172);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.Size = new System.Drawing.Size(194, 73);
            this.labelTempo.TabIndex = 4;
            this.labelTempo.Text = "59:59";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(46, 346);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(125, 64);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(189, 346);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(125, 64);
            this.btnParar.TabIndex = 6;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.labelTempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSegundos);
            this.Controls.Add(this.comboMinutos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(377, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(377, 489);
            this.Name = "Form1";
            this.Text = "Contagem Regressiva";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMinutos;
        private System.Windows.Forms.ComboBox comboSegundos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTempo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Timer Timer;
    }
}

