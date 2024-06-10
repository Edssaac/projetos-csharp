
namespace SnakeGame
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.GameCanvas = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtActualScore = new System.Windows.Forms.Label();
            this.txtGameMessage = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTopScore = new System.Windows.Forms.Label();
            this.txtActualTopScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameCanvas
            // 
            this.GameCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(205)))), ((int)(((byte)(183)))));
            this.GameCanvas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GameCanvas.Location = new System.Drawing.Point(0, 36);
            this.GameCanvas.Name = "GameCanvas";
            this.GameCanvas.Size = new System.Drawing.Size(484, 540);
            this.GameCanvas.TabIndex = 0;
            this.GameCanvas.TabStop = false;
            this.GameCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.updateGraphics);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(3, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(99, 19);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Pontuação:";
            // 
            // txtActualScore
            // 
            this.txtActualScore.AutoSize = true;
            this.txtActualScore.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualScore.Location = new System.Drawing.Point(99, 9);
            this.txtActualScore.Name = "txtActualScore";
            this.txtActualScore.Size = new System.Drawing.Size(18, 19);
            this.txtActualScore.TabIndex = 2;
            this.txtActualScore.Text = "0";
            // 
            // txtGameMessage
            // 
            this.txtGameMessage.AutoSize = true;
            this.txtGameMessage.BackColor = System.Drawing.Color.Black;
            this.txtGameMessage.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.txtGameMessage.ForeColor = System.Drawing.Color.Yellow;
            this.txtGameMessage.Location = new System.Drawing.Point(165, 274);
            this.txtGameMessage.Name = "txtGameMessage";
            this.txtGameMessage.Size = new System.Drawing.Size(155, 28);
            this.txtGameMessage.TabIndex = 3;
            this.txtGameMessage.Text = "Fim de Jogo";
            this.txtGameMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.txtActualTopScore);
            this.panel1.Controls.Add(this.txtTopScore);
            this.panel1.Controls.Add(this.txtScore);
            this.panel1.Controls.Add(this.txtActualScore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 37);
            this.panel1.TabIndex = 4;
            // 
            // txtTopScore
            // 
            this.txtTopScore.AutoSize = true;
            this.txtTopScore.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopScore.Location = new System.Drawing.Point(283, 9);
            this.txtTopScore.Name = "txtTopScore";
            this.txtTopScore.Size = new System.Drawing.Size(162, 19);
            this.txtTopScore.TabIndex = 3;
            this.txtTopScore.Text = "Pontuação Máxima:";
            // 
            // txtActualTopScore
            // 
            this.txtActualTopScore.AutoSize = true;
            this.txtActualTopScore.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualTopScore.Location = new System.Drawing.Point(442, 9);
            this.txtActualTopScore.Name = "txtActualTopScore";
            this.txtActualTopScore.Size = new System.Drawing.Size(18, 19);
            this.txtActualTopScore.TabIndex = 4;
            this.txtActualTopScore.Text = "0";
            // 
            // GameScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtGameMessage);
            this.Controls.Add(this.GameCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 615);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 615);
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnakeGame";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameCanvas;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtActualScore;
        private System.Windows.Forms.Label txtGameMessage;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtActualTopScore;
        private System.Windows.Forms.Label txtTopScore;
    }
}

