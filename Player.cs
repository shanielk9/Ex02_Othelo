using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Othelo
{
    class Player
    {
        private string m_Name;
        private int m_Score;
        private string m_Sign;
        

        public Player(string i_Name, string i_Sign)
        {
            m_Name = i_Name;
            m_Sign = i_Sign;
        }

        public string Sign
        {
            get { return m_Sign; }
            set { m_Sign = value; }
        }

        public string PlayerName
        {
            get { return m_Name; }
        }

        public int PlayerScore
        {
            get { return m_Score; }
            set { m_Score = value; }
        }
        public string GetOpponentSign()
        {
            string OpponentSign;
            if (this.m_Sign == "O")
                OpponentSign = "X";
            else
                OpponentSign = "O";
            return OpponentSign;
        }

        
    }
}
