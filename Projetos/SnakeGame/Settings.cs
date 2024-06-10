using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public enum Directions
    { 
        //Criando uma class Enum para classificar as direções:
        Left,
        Right,
        Up,
        Down,    
    };

    class Settings
    {
        //Variáveis necessárias para o funcionamento do jogo:
        public static int Width { get; set; } //Largura da nossa cobra;
        public static int Height { get; set; } //Altura da nossa cobra;
        public static int Speed { get; set; } //Velocidade da nossa cobra;
        public static int Score { get; set; } //Pontuação do momento; 
        public static int Points { get; set; } //Pontos a serem coletados;
        public static bool GameOver { get; set; } //Verificando se o jogo acabou;
        public static Directions direction { get; set; } //Definindo a direção atual;


        //Definindo nossos valores bases a serem usados:
        public Settings()
        {
            Width = 25; //Largura inicial de 16px;
            Height = 25; //Altura inicial de 16px;
            Speed = 15; //Velocidade inicial de 20px;
            Score = 0; //Pontuação inicial 0;
            Points = 35; //Somando 35 ao Score a cada maça pega;
            GameOver = false; //Começando o jogo de forma valida;
            direction = Directions.Down; //Começando o jogo indo para baixo;
        }

    }
}
