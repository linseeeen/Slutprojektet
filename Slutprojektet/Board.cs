using System;

namespace Slutprojektet
{
    public class Board
    {
        private static int[,] board = new int [20, 10];
        private static (int, int) wateringCan = (1, 2);
        private static (int, int) store = (1, 0);
        private static (int, int) gardenHoe = (1,4);
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
        private static void Stuff(){
            board[wateringCan.Item1, wateringCan.Item2] = 1;
            board[store.Item1, store.Item2] = 1;
            board[gardenHoe.Item1, gardenHoe.Item2] = 1;
        }
        public static void Draw(){
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