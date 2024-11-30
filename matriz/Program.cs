public class Program
{
    static void Main()
    {
        // Paso 1: Pedir al usuario el tamaño de la matriz
        Console.Write("Ingrese el tamaño de la matriz (N x N): ");
        int tamaño = int.Parse(Console.ReadLine()); // Leer y convertir la entrada a un número entero

        // Paso 2: Crear la matriz y llenarla con números aleatorios
        int[,] matriz = new int[tamaño, tamaño];
        Random aleatorio = new Random(); // Generador de números aleatorios

       
    }

   
}