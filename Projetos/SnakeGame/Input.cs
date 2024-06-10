using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;    //Para podermos usar a classe Hashtable
using System.Windows.Forms;  //Para usarmos as classes Key;

namespace SnakeGame
{
    class Input
    {
        //Criando uma instância da classe Hashtable,
        //que serve para otimização da entrada das teclas:
        private static Hashtable keyTable = new Hashtable();

        public static bool keyPress(Keys key)
        {
            //Essa função nos retornará uma tecla;

            if ( keyTable[key] == null )
            {
                //Se não for encontrada a tecla:
                return false;
            }

            //No caso de existir uma tecla válida então a teremos:
            return (bool)keyTable[key];
        }

        public static void changeState(Keys key, bool state)
        {
            //Essa função tem como objetivo, mudar o estado das teclas e do jogador:
            keyTable[key] = state;
        }

    }
}