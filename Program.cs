/*
Escriba un programa en C# que almacene valores de tipo entero en una matriz cuadrado de tamaño
N * N. El programa debe imprimir la suma de los elementos de cada fila, cada columna y de ambas
diagonales.
*/
using System;

namespace MatrizCuadrada
{
  class Program
  {
    static void Main()
    {
      // Definir el tamaño de la matriz
      const int N = 4;

      // Crear la matriz y llenarla con valores aleatorios
      int[,] matriz = new int[N, N];
      Random rnd = new Random();
      for (int i = 0; i < N; i++)
      {
        for (int j = 0; j < N; j++)
        {
          matriz[i, j] = rnd.Next(10);
        }
      }

      // Imprimir la matriz
      Console.WriteLine("Matriz:");
      for (int i = 0; i < N; i++)
      {
        for (int j = 0; j < N; j++)
        {
          Console.Write($"{matriz[i, j]} ");
        }
        Console.WriteLine();
      }
      Console.WriteLine();

      // Sumar los elementos de cada fila
      for (int i = 0; i < N; i++)
      {
        int sumaFila = 0;
        for (int j = 0; j < N; j++)
        {
          sumaFila += matriz[i, j];
        }
        Console.WriteLine($"La suma de los elementos de la fila {i+1} es {sumaFila}.");
      }
      Console.WriteLine();

      // Sumar los elementos de cada columna
      for (int j = 0; j < N; j++)
      {
        int sumaColumna = 0;
        for (int i = 0; i < N; i++)
        {
          sumaColumna += matriz[i, j];
        }
        Console.WriteLine($"La suma de los elementos de la columna {j+1} es {sumaColumna}.");
      }
      Console.WriteLine();

      // Sumar los elementos de la diagonal principal
      int sumaDiagonalPrincipal = 0;
      for (int i = 0; i < N; i++)
      {
        //en este caso nos desplazamos con las posiciones de i, para lograr obtener los valores de una diagonal
        //es decir, si estamos en la fila 0, estaremos en la columna 0, si nos desplazamos a la fila 1, estaremos
        //en la columna 1
        sumaDiagonalPrincipal += matriz[i, i];
      }
      Console.WriteLine($"La suma de los elementos de la diagonal principal es {sumaDiagonalPrincipal}.");
      Console.WriteLine();

      // Sumar los elementos de la diagonal secundaria
      int sumaDiagonalSecundaria = 0;
      for (int i = 0; i < N; i++)
      {
        //usamos el valor de N para posicionarnos al final de la fila, y de esta forma ir disminuyendo
        //en este caso N = 4, pero el valor 4 en nuestro array es un valor nulo, entonces restamos
        //el valor de i, en la primer iteracion seria 4 = 0, por eso usamos -1, para lograr movernos 1 
        //posicion mas, de esta forma logramos desplazarnos correctamente de forma diagonal 
        sumaDiagonalSecundaria += matriz[i, N - i - 1];
      }
      Console.WriteLine($"La suma de los elementos de la diagonal secundaria es {sumaDiagonalSecundaria}.");

      Console.ReadLine();
    }
  }

}