using System;

class Program
{
    static void Main()
    {
        // Ruta del archivo de entrada
        string filePath = @"C:/Users/felip/OneDrive - Universidad Católica del Uruguay/Facultad/tablero.txt"; // Cambia esto a la ubicación de tu archivo

        // Crear un objeto BoardLoader para cargar el tablero desde el archivo
        BoardLoader boardLoader = new BoardLoader();
        bool[,] initialBoard = boardLoader.LoadBoardFromFile(filePath);

        // Crear un objeto GameOfLife con el tablero cargado
        GameOfLife game = new GameOfLife(initialBoard);

        // Crear un objeto BoardPrinter para imprimir el tablero en la consola
        BoardPrinter boardPrinter = new BoardPrinter();

        // Loop para mostrar las generaciones y actualizar el tablero
        while (true)
        {
            // Imprimir el tablero actual en la consola
            boardPrinter.PrintBoard(game);

            // Calcular y actualizar la siguiente generación
            game.UpdateGeneration();

            // Pausa antes de mostrar la siguiente generación
            System.Threading.Thread.Sleep(300); // 300 milisegundos (0.3 segundos)
        }
    }
}
