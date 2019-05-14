using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Othelo
{
    class Player
    {
        private bool IsComputer = true;
        private string m_PlayerName;
        private int m_PlayerScore;

        public Player(String i_PlayerName)
        {
            m_PlayerName = i_PlayerName;
        }

        public int CurrentScore
        {
            get { return m_PlayerScore; }
            set { m_PlayerScore = value; }
        } 

        


    }
}
