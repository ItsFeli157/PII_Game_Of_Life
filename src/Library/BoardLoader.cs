using System.IO;

public class BoardLoader
{
    public bool[,] LoadBoardFromFile(string filePath)
    {
        string[] contentLines = File.ReadAllLines(filePath);
        int height = contentLines.Length;
        int width = contentLines[0].Length;
        bool[,] board = new bool[width, height];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (contentLines[y][x] == '1')
                {
                    board[x, y] = true;
                }
            }
        }

        return board;
    }
}
