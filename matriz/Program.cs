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

        // Paso 4: Inicializar posición inicial y suma acumulada
        int posicionFila = 0, posicionColumna = 0; // Comienza en la esquina superior izquierda
        int sumaAcumulada = matriz[posicionFila, posicionColumna];
        matriz[posicionFila, posicionColumna] = 0; // Poner la posición inicial en 0

        Console.WriteLine($"\nPosición inicial: (0, 0), Suma acumulada: {sumaAcumulada}");
        MostrarMatriz(matriz); // Mostrar la matriz después del primer movimiento

        // Paso 5: Moverse por la matriz con las teclas de flecha
        while (true)
        {
            Console.Write("para salir oprime la tecla ESCAPE: ");
            ConsoleKeyInfo tecla = Console.ReadKey(); // Leer la tecla presionada
            if (tecla.Key == ConsoleKey.Escape) // Si se presiona "ESCAPE", salir
            {
                Console.WriteLine("\nSaliendo del programa...");
                return;
            }

            // Procesar las teclas de flecha
            switch (tecla.Key)
            {
                case ConsoleKey.UpArrow: // Flecha hacia arriba
                    if (posicionFila > 0) posicionFila--;
                    break;
                case ConsoleKey.DownArrow: // Flecha hacia abajo
                    if (posicionFila < filas - 1) posicionFila++;
                    break;
                case ConsoleKey.LeftArrow: // Flecha hacia la izquierda
                    if (posicionColumna > 0) posicionColumna--;
                    break;
                case ConsoleKey.RightArrow: // Flecha hacia la derecha
                    if (posicionColumna < columnas - 1) posicionColumna++;
                    break;
                default:
                    Console.WriteLine("\nMovimiento no válido. Intente nuevamente.");
                    continue;
            }

            // Poner el número en la nueva posición a 0 y sumar el valor
            sumaAcumulada += matriz[posicionFila, posicionColumna];
            matriz[posicionFila, posicionColumna] = 0; // Marcar la celda como 0

            // Mostrar la nueva matriz
            Console.Clear(); // Limpiar la pantalla para mostrar la matriz actualizada
            Console.WriteLine($"Posición actual: ({posicionFila}, {posicionColumna}), Suma acumulada: {sumaAcumulada}");
            MostrarMatriz(matriz); // Mostrar la matriz después de cada movimiento
        }
    }

   
}