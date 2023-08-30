public class GameOfLife
{
    public bool[,] gameBoard { get; private set; }
    private int boardWidth;
    private int boardHeight;

    public GameOfLife(bool[,] initialBoard)
    {
        gameBoard = initialBoard;
        boardWidth = initialBoard.GetLength(0);
        boardHeight = initialBoard.GetLength(1);
    }

    public void UpdateGeneration()
    {
        bool[,] cloneboard = new bool[boardWidth, boardHeight];
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = CountAliveNeighbors(x,y);

                if (gameBoard[x,y])
                {
                    //Celula viva
                    if (aliveNeighbors < 2 || aliveNeighbors > 3)
                    {
                        //Celula muere por baja poblacion o sobrepoblacion
                        cloneboard[x,y] = false;
                    }
                    else
                    {
                        //Celula sobrevive
                        cloneboard[x,y]=true;
                    }

                }
                else
                {
                    //Celula muerta
                    if (aliveNeighbors == 3)
                    {
                        //Celula nace por reproduccion
                        cloneboard[x,y] = true;
                    }
                    else
                    {
                        //celula permanece muerta
                        cloneboard[x,y] = false;
                    }
                }
            }
        }
        gameBoard = cloneboard;
    }

    private int CountAliveNeighbors(int x, int y)
    {
        int aliveNeighbors = 0;
        for (int i = x - 1; i <= x + 1; i++)
        {
            for (int j = y - 1; j <= y + 1; j++)
            {
                if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && gameBoard[i, j])
                {
                    aliveNeighbors++;
                }
            }
        }
        if (gameBoard[x, y])
        {
            aliveNeighbors--;
        }
        return aliveNeighbors;
    }
}