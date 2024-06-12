using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
            customizeDesign(); //Inciando a aplicação com os menus escondidos;
        }


        //############## FUNÇÕES A SEREM USADAS ##############// <- COMEÇO DA SESSÃO

        //Usando para esconder os submenus criados:
        private void customizeDesign()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistsSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        //Verificando se há algum submenu aberto e fechando se houver:
        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;
            if (panelPlaylistsSubMenu.Visible == true)
                panelPlaylistsSubMenu.Visible = false;
            if (panelToolsSubMenu.Visible == true)
                panelToolsSubMenu.Visible = false;
        }

        //Escolhendo um subMenu para mostrar e escondendo o que estiver aberto - se houver:
        private void showSubMenu(Panel subMenu)
        {
            //Clicando no subMenu.
            if (subMenu.Visible == false) //Se ele não estiver aberto,
            {
                hideSubMenu(); //Fechamos os que estão - se houver algum,
                subMenu.Visible = true; //E abrimos o que selecionamos;
            }
            else //Se ele já estiver aberto,
                subMenu.Visible = false; //Então fechamos ele.
        }

        private Form activeForm = null; //Para armazenar o formulário que estiver aberto;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) //Se houver um formulário aberto,
            {
                activeForm.Close(); //Então fechamos ele;
            }

            activeForm = childForm; //Passando o formulário que abrimos;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; //Removendo as bordas do formulário;
            childForm.Dock = DockStyle.Fill; //Preenchedo o formulário no panel;

            panelChildForm.Controls.Add(childForm); //Adicionando o formulário ao panel;
            childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show(); //Mostrando ele;
        }

        //-------------- FUNÇÕES A SEREM USADAS --------------// <- FIM DA SESSÃO


        //############## BOTÕES E INTERAGÍVEIS ##############// <- COMEÇO DA SESSÃO

        #region Ações com a logo lateral
        //Logo lateral, se clicado volta a tela inicial:
        private void picSideLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Dispose();
        }
        //Mudando a cor de fundo da imagem quando passar o mouse por cima:
        private void picSideLogo_MouseEnter(object sender, EventArgs e)
        {
            picSideLogo.BackColor = Color.FromArgb(35, 32, 39);
        }
        //Quando o ponteiro do mouse sair de cima da imagem, voltamos a cor de fundo ao normal:
        private void picSideLogo_MouseLeave(object sender, EventArgs e)
        {
            picSideLogo.BackColor = Color.FromArgb(11, 7, 17);
        }
        #endregion


        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }
        #region MediaSubMenu
        private void btnOpenFiles_Click(object sender, EventArgs e)
        {
            //Fazer código:
            openChildForm(new mediaOpenFiles()); //Chamando a tela para escolher e abrir um arquivo;

            //E fechar o SubMenu():
            hideSubMenu();
        }
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            //Fazer código:

            //E fechar o SubMenu():
            hideSubMenu();
        }
        private void btnRecentMedia_Click(object sender, EventArgs e)
        {
            //Fazer código:

            //E fechar o SubMenu():
            hideSubMenu();
        }
        #endregion


        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistsSubMenu);
        }
        #region PlaylistSubMenu
        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {
            //Fazer código:

            //E fechar o SubMenu():
            hideSubMenu();
        }
        private void btnManagePlaylists_Click(object sender, EventArgs e)
        {
            //Fazer código:

            //E fechar o SubMenu():
            hideSubMenu();
        }
        private void btnImportPlaylist_Click(object sender, EventArgs e)
        {
            //Fazer código:

            //E fechar o SubMenu():
            hideSubMenu();
        }
        private void btnExportPlaylist_Click(object sender, EventArgs e)
        {
            //Fazer código:

            //E fechar o SubMenu():
            hideSubMenu();
        }
        #endregion


        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            //Fazer código:
            openChildForm(new Equalizer()); //Chamando a tela do equalizador;

            //E fechar o SubMenu():
            hideSubMenu();
        }


        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        #region ToolsSubMenu
        private void btnEffectsFilters_Click(object sender, EventArgs e)
        {
            //Fazer código:

            //E fechar o SubMenu():
            hideSubMenu();
        }
        private void btnPreferences_Click(object sender, EventArgs e)
        {
            //Fazer código:

            //E fechar o SubMenu():
            hideSubMenu();
        }
        #endregion


        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Fazer código:

            //E fechar o SubMenu():
            hideSubMenu();
        }

        //Para sairmos da aplicação:
        private void btnLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Para ocultar/desocultar o menu:
        private void picMenu_Click(object sender, EventArgs e)
        {
            if (panelSideMenu.Visible == true)
                panelSideMenu.Visible = false;
            else
                panelSideMenu.Visible = true;
        }

        //-------------- BOTÕES E INTERAGÍVEIS --------------// <- FIM DA SESSÃO

        //############## BARRA DE TÍTULO E BOTÕES ##############// <- COMEÇO DA SESSÃO

        bool canMove = false;
        Point newLocaltion;

        //Clicando:
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            canMove = true;
            newLocaltion = new Point(e.X, e.Y);
        }
        //Arrastando:
        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (canMove)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point( p.X-newLocaltion.X, p.Y -newLocaltion.Y) ;
            }
        }
        //Soltando:
        private void panelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            canMove = false;
        }

        //Botões:
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Fechando a aplicação;
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized) //A aplicação está maximizada?
            {
                this.WindowState = FormWindowState.Normal; //se sim, então volte ao tamanho normal!
                btnMaximize.BackgroundImage = Properties.Resources.Maximize; //Atualizando a foto para o novo contexto;
            }
            else if (WindowState == FormWindowState.Normal) //se já estiver no tamanho normal,
            {
                this.WindowState = FormWindowState.Maximized; //então maximize!
                btnMaximize.BackgroundImage = Properties.Resources.Normal; //Atualizando a foto para o novo contexto;
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Minimzando a aplicação;
        }
        //Clicando duas vezes na barra de títulos:
        private void panelTitleBar_DoubleClick(object sender, EventArgs e)
        {
            btnMaximize_Click(sender, e); //Reutizando a função do botão de maximizar;
        }

        //-------------- BARRA DE TÍTULO E BOTÕES --------------// <- FIM DA SESSÃO

    }
}