using System;
using System.Text;
using System.Threading;

public class BoardPrinter
{
    public void PrintBoard(GameOfLife game)
    {
        int width = game.gameBoard.GetLength(0);
        int height = game.gameBoard.GetLength(1);

        while (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (game.gameBoard[x, y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());

            // Invocar método para calcular siguiente generación
            game.UpdateGeneration();

            Thread.Sleep(300);
        }
    }
}

/*
using System;
using System.Text;
using System.Threading;

public class BoardPrinter
{
    public void PrintBoard(bool[,] board)
    {
        int width = board.GetLength(0);
        int height = board.GetLength(1);

        while (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (board[x, y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            
            // Invocar método para calcular siguiente generación
            game.UpdateGeneration();

            Thread.Sleep(300);
        }
    }
}
*/