using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Othelo
{
    class Game
    {
        public Player[] m_Players;
        public Board m_boardGame;
        public bool m_AgainstComputer;
   
        public Game(int i_BoardSize, string i_ChosenGameState)
        {
            m_Players = new Player[2];
            m_boardGame = new Board(i_BoardSize);
            if (i_ChosenGameState == "P")
            {
                m_AgainstComputer = false;
            }
            else
            {
                m_AgainstComputer = true;
            }

        }
        public void AddPlayer(int i_Index, string i_PlayerName, string i_PlayerSign)
        {
            m_Players[i_Index] = new Player(i_PlayerName, i_PlayerSign);
        }
        public void PlayerVsComputer()
        {




        }
    }
}


