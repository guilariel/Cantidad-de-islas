using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cantidad_de_islas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] grid = [
  ['1','1','0','0','0'],
  ['1','1','0','0','0'],
  ['0','0','1','0','0'],
  ['0','0','0','1','1']
];
            Console.WriteLine(NumIslands(grid));
            Console.ReadLine();
        }
        public static int NumIslands(char[][] grid)
        {
            int CantidadDeIslas = 0;

            for(int i = 0;i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (HayIsla(grid, i, j))
                    {
                        CantidadDeIslas++;
                        Console.WriteLine("1");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
            }

            return CantidadDeIslas;
        }

        public static bool HayIsla(char[][] grid,int fila, int Posicion)
        {
            if (grid[fila][Posicion] == '0') return false;

            char[][] nuevogrid = grid;
            nuevogrid[fila][Posicion] = '0';

            if (fila + 1 < grid.Length && grid[fila + 1][Posicion] == '1' )
            {
                HayIsla(nuevogrid, fila + 1, Posicion);
            }
            if (fila - 1 >= 0 && grid[fila - 1][Posicion] == '1')
            {
                HayIsla(nuevogrid, fila - 1, Posicion);
            }
            if (Posicion + 1 < grid[fila].Length && grid[fila][Posicion + 1] == '1')
            {
                HayIsla(nuevogrid, fila, Posicion + 1);
            }
            if (Posicion - 1 >= 0 && grid[fila][Posicion - 1] == '1')
            {
                HayIsla(nuevogrid, fila, Posicion - 1);
            }

            //grid = nuevogrid;

            return true;
        }
    }
}
