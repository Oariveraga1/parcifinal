public class Program
{
    static void Main()
    {
        // Paso 1: Pedir al usuario las dimensiones de la matriz
        Console.Write("Ingrese el número de filas de la matriz: ");
        int filas = int.Parse(Console.ReadLine()); // Leer y convertir la entrada a un número entero para filas

        Console.Write("Ingrese el número de columnas de la matriz: ");
        int columnas = int.Parse(Console.ReadLine()); // Leer y convertir la entrada a un número entero para columnas

        // Paso 2: Crear la matriz y llenarla con números aleatorios
        int[,] matriz = new int[filas, columnas];
        Random aleatorio = new Random(); // Generador de números aleatorios

        for (int fila = 0; fila < filas; fila++) // Recorrer las filas
        {
            for (int columna = 0; columna < columnas; columna++) // Recorrer las columnas
            {
                matriz[fila, columna] = aleatorio.Next(1, 10); // Número entre 1 y 9
            }
        }

        // Paso 3: Mostrar la matriz generada
        Console.WriteLine("\nMatriz generada:");
        MostrarMatriz(matriz);

       
    }

    
}