using System;

namespace Slutprojektet
{
    public class Board
    {
        private int[,] board = new int [20, 10];
        private (int, int) store = (1, 0);
        private (int, int) wateringCan = (1, 2);
        private (int, int) wheelbarrow = (1,4);
        private (int, int) gardenHoe = (1,6);
        public Board()
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    board [x, y] = 0;
                }
            }
        }
        private void Stuff(){
            board[store.Item1, store.Item2] = 1;
            board[wateringCan.Item1, wateringCan.Item2] = 2;
            board[wheelbarrow.Item1, wheelbarrow.Item2] = 3;
            board[gardenHoe.Item1, gardenHoe.Item2] = 4;
        }
        public void Draw(){
            Stuff();
            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    Console.Write(board[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}