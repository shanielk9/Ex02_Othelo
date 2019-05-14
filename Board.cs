using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Othelo
{
    class Board
    {
        private int m_Size;
        private string[,] m_Board;
        private int m_CountBlack;
        private int m_CountWhite;
        private int m_CountEmpty;


        public Board(int i_Size) //constructor
        {
            m_Size = i_Size;
            m_Board = new string[m_Size, m_Size];
            for (int i = 0; i < m_Size; i++)
            {
                for (int j = 0; j < m_Size; j++)
                {
                    m_Board[i, j] = " ";
                }
            }

            m_Board[m_Size / 2 - 1, m_Size / 2 - 1] = "O";
            m_Board[m_Size / 2 - 1, m_Size / 2] = "X";
            m_Board[m_Size / 2, m_Size / 2 - 1] = "X";
            m_Board[m_Size / 2, m_Size / 2] = "O";
        }

        public int CountBlack
        {
            get { return m_CountBlack; }
            set { m_CountBlack = value; }
        } // count current number of blacks on the board

        public int CountWhite
        {
            get { return m_CountWhite; }
            set { m_CountWhite = value; }
        } // count current number of whites on the board

        public int CountEmpty
        {
            get { return m_CountEmpty; }
            set { m_CountWhite = value; }
        }


        public void PrintBoard()
        {
            Console.Write("      ");
            for (int i = 0; i < m_Size; i++)
            {
                char c = Convert.ToChar('A' + i);
                Console.Write(c + "     ");
            }

            Console.WriteLine();
            Console.Write("   ");
            for (int i = 0; i < m_Size; i++)
            {
                Console.Write("======");
            }
            Console.WriteLine("=");

            for (int i = 0; i < m_Size; i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < m_Size; j++)
                {
                    Console.Write("  |  ");
                    Console.Write(m_Board[i, j]);
                }

                Console.WriteLine("  |");
                Console.Write("   ");
                for (int k = 0; k < m_Size; k++)
                {
                    Console.Write("======");
                }
                Console.WriteLine("=");
            }
        }

        public void UpdateBoard() //TODO: implementaion
        {
           
        }

        


    }
}
