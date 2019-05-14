using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Othelo
{
    class UI
    {
        private bool m_IsQuit = true;
        public void RunMenu()
        {
            Console.WriteLine("Hello! Welcome to Othello game");
            Console.WriteLine("===============================");
            Console.WriteLine("Please Enter name of first Player: ");
            Player player1 = new Player(Console.ReadLine());
            Console.WriteLine("Press P for two players game or C to play against the computer");
            string playerChoose = Console.ReadLine();


        }

        public void StartGame()
        {
           
           
        }
       

        

    }
}
