using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Texter
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openText; //variável privada para abrir arquivos;
        private SaveFileDialog saveText; //variável privada para salvar arquivos;
        private FontDialog fontText; //variável privada para mudar a fonte do texto;
        private ColorDialog colorText; //variável privada para mudar a cor do texto;
        private ColorDialog backgroundColor; //variável privada para mudar a cor de fundo;

        private string dir;
        public Form1()
        {
            InitializeComponent();

            this.Text = "Sem título" + " - Texter";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fontText = new FontDialog();
            colorText = new ColorDialog();
            backgroundColor = new ColorDialog();

        }

        private void createNew() //Função para criar um novo arquivo:
        {
            try
            {

                if ( /*(!string.IsNullOrEmpty(this.richTextBox1.Text)) &&*/ this.Text != "Sem título" + " - Texter")
                {
                    this.Text = "Sem título" + " - Texter"; //Muda o título do arquivo;
                    this.richTextBox1.Text = string.Empty; //Limpa o rich text box; 
                }
                else if (!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    DialogResult info = MessageBox.Show("Deseja salvar a produção atual?", "Cuidado!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                    if (info == DialogResult.Yes)
                    {
                        saveFile();
                        this.Text = "Sem título" + " - Texter"; //Muda o título do arquivo;
                        this.richTextBox1.Text = string.Empty; //Limpa o rich text box; 
                    }
                    else if (info == DialogResult.No)
                    {
                        this.Text = "Sem título" + " - Texter"; //Muda o título do arquivo;
                        this.richTextBox1.Text = string.Empty; //Limpa o rich text box; 
                    }

                }

            }
            catch (Exception ex)
            {}
            finally
            {}

        }

        private void openFile() //Função para abrir um arquivo já existente:
        {
            try
            {
                openText = new OpenFileDialog();

                if (openText.ShowDialog() == DialogResult.OK) //Verifica se um arquivo foi selecionado;
                {
                    this.richTextBox1.Text = File.ReadAllText(openText.FileName); //Pega o texto do arquivo selecionado e joga nas linhas do rich text box;
                    FileInfo fileInfo = new FileInfo(openText.FileName); //variável que armazena o diretorio do arquivo escolhido;
                    dir = fileInfo.ToString(); //Pegando o diretorio para poder salvar o arquivo depois;
                    this.Text = fileInfo.Name + " - Texter"; //Remove o resto do diretorio e deixa apenas o nome do arquivo, e concate com o nome do app para mudar o título na janela;
                }

            }
            catch (Exception ex)
            {   //Mensagem de erro:
                MessageBox.Show("Problemas ao abrir o arquivo selecionado", "#303", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                openText = null;
            }

        }

        private void saveFile() //Função para salvar o arquivo em que estamos mexendo:
        {
            try
            {
                saveText = new SaveFileDialog();

                saveText.Filter = "Arquivo de Texto (*.txt) | *.txt"; //Prés-seleção do tipo do arquivo;

                if (this.Text != "Sem título" + " - Texter")
                {
                    //Salva o arquivo aberto:
                    File.WriteAllText(dir, this.richTextBox1.Text);
                }
                else if (saveText.ShowDialog() == DialogResult.OK)
                {
                    //Cria um arquivo para salvar o texto em produção: 
                    File.WriteAllText(saveText.FileName, this.richTextBox1.Text);
                    //Atualiza o nome da janela:
                    FileInfo fileInfo = new FileInfo(saveText.FileName);
                    dir = saveText.FileName;
                    this.Text = fileInfo.Name + " - Texter";

                }

            }
            catch (Exception ex)
            {}
            finally
            {}

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {}

        //Referente ao "Arquivo":
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNew(); //Chamando a função que cria um novo arquivo;
        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 texter = new Form1();
            texter.Show(); //Abrindo nova janela; 
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile(); //Chamando a função que abre um arquivo já existente;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(); //Chamando a função que salva o arquivo em edição;
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                saveText = new SaveFileDialog();
                saveText.Filter = "Arquivo de Texto (*.txt) | *.txt";

                if (saveText.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveText.FileName, this.richTextBox1.Text);
                }

            }
            catch (Exception ex) {}
            finally {}
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            documento.Print(); //Chama a instrução para que a impressão comece.
        }
        private void documento_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Dados:
            string texto = richTextBox1.Text;
            Font letra = new Font( richTextBox1.Font.FontFamily, richTextBox1.Font.Size, richTextBox1.Font.Style, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(richTextBox1.ForeColor);
            Point ponto = new Point(100, 100);

            //Instrução para imprimir:
            e.Graphics.DrawString(texto, letra, cor, ponto);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.richTextBox1.Text) && this.Text == "Sem título" + " - Texter")
            {
                DialogResult info = MessageBox.Show("Deseja sair sem salvar?", "Cuidado!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (info == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (info == DialogResult.No)
                {
                    saveFile();
                    this.Close();
                }
            
            }
            else
            {
                this.Close();
            }

        }

        private void formatarToolStripMenuItem_Click(object sender, EventArgs e)
        {}

        //Referente ao "Formatar":
        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (fontText.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Font = fontText.Font;
                }

            }
            catch (Exception ex)
            {}
            finally
            {}

        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (colorText.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.ForeColor = colorText.Color;
                }
            }
            catch (Exception ex)
            {}
            finally
            {}

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {}

        //Referente ao "Editar":
        private void fundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (backgroundColor.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.BackColor = backgroundColor.Color;
                }
            }
            catch (Exception ex)
            {}
            finally
            {}

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {}

        //Referente ao "+":
        private void edssaacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Criando uma chamada para a nova janela: 
            TexterDetalhes newTab = new TexterDetalhes(this);
            this.Enabled = false; //Desabilita janela de fundo;
            newTab.ShowDialog();
            
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {}


    }
}

