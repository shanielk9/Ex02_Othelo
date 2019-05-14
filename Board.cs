using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Othelo
{
    class Board
    {
        private static readonly string sr_Empty = " ";
        private static readonly string sr_Black = "X";
        private static readonly string sr_White = "O";

        private string[,] m_Board;
        private int m_CountBlack;
        private int m_CountWhite;
        private int m_CountEmpty;

        
        public Board(int i_Size) //constructor
        {
            
            m_Board = new string[i_Size, i_Size];
            for (int i = 0; i < i_Size; i++)
            {
                for (int j = 0; j < i_Size; j++)
                {
                    m_Board[i, j] = " ";
                }
            }

            m_Board[i_Size / 2 - 1, i_Size / 2 - 1] = "O";
            m_Board[i_Size / 2 - 1, i_Size / 2] = "X";
            m_Board[i_Size / 2, i_Size / 2 - 1] = "X";
            m_Board[i_Size / 2, i_Size / 2] = "O";
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

        public string[,] ScreenBoard
        {
            get { return m_Board; }
            set { m_Board = value; }
        }
        
        public bool IsValidMove(Player i_CurrentPlayer, int i_Row, int i_Col)
        {
            bool IsValid = true;

            if (this.m_Board[i_Row, i_Col] != sr_Empty)
                IsValid = false;

            else
            {
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (!(i == i_Row) && (j == i_Col) && hasPossibleToFlip(i_CurrentPlayer, i_Row , i_Col, i, j))
                            IsValid = true;
                    }
                }
            }
           
            return IsValid;
        }

        //Check if any opponent discs on a given path
        private bool hasPossibleToFlip(Player i_Player, int i_Row, int i_Col, int i_DirectionRow, int i_DirectionCol)
        {
            bool IsPossible = true;

            int RowToCheck = i_Row + i_DirectionRow;
            int ColToCheck = i_Col + i_DirectionCol;

            while(RowToCheck >= 0 && RowToCheck<=this.m_Board.GetLength(0) && ColToCheck >=0 && 
                ColToCheck<= this.m_Board.GetLength(0) && (this.m_Board[RowToCheck, ColToCheck] == i_Player.GetOpponentSign()))
            {

                RowToCheck += i_DirectionRow;
                ColToCheck += i_DirectionCol;
            }
             
            if(RowToCheck < 0 || RowToCheck > this.m_Board.GetLength(0)-1 || ColToCheck < 0 || 
                ColToCheck > this.m_Board.GetLength(0) - 1 || (RowToCheck - i_DirectionRow == i_Row && ColToCheck - i_DirectionCol == i_Col) ||
                this.m_Board[RowToCheck,ColToCheck] != i_Player.Sign)
            {
                IsPossible = false;
            }

                return IsPossible;
        }


        public void UpdateBoardState(Player i_Player, int i_Row, int i_Col) //TODO: implementaion
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if(hasPossibleToFlip(i_Player, i_Row, i_Col, i, j))
                    {
                        int RowToChange = i_Row + i;
                        int ColToChange = i_Col + j;

                        while (this.m_Board[RowToChange, ColToChange] != i_Player.Sign)
                        {
                            this.m_Board[RowToChange, ColToChange] = i_Player.Sign;
                            RowToChange = i_Row + i;
                            ColToChange = i_Col + j;
                        }
                    }
                }
            }

        }
    }
}
