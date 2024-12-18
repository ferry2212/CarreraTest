using System;
using System.Collections.Generic;

public class Carrera
{
    public static Dictionary<int, int> CalcularDistancies(List<int[]> corredors)
    {
        var distancies = new Dictionary<int, int>();

        foreach (var corredor in corredors)
        {
            int id = corredor[0];
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 1; i < corredor.Length; i++)
            {
                if (corredor[i] > max) max = corredor[i];
                if (corredor[i] < min) min = corredor[i];
            }

            int distancia = max - min;

            if (distancies.ContainsKey(id))
            {
                distancies[id] += distancia;
            }
            else
            {
                distancies[id] = distancia;
            }
        }

        return distancies;
    }

    public static void MostrarDistancies(Dictionary<int, int> distancies)
    {
        foreach (var kvp in distancies)
        {
            Console.WriteLine($"Corredor {kvp.Key}: {kvp.Value} metres");
        }
    }
}
using System;
class Programa
{
    static void Main()
    {
        var corredors = new List<int[]>
        {
            new int[] {1, 5, 1, 9, 3},
            new int[] {2, 7, 5, 3, 4},
            new int[] {3, 2, 4, 6, 8},
            new int[] {1, 3, 2, 7, 4},
            new int[] {2, 2, 4, 6, 4},
            new int[] {3, 6, 1, 6, 8},
            new int[] {1, 6, 9, 5, 7},
            new int[] {2, 1, 4, 2, 5},
            new int[] {3, 3, 4, 8, 8}
        };

        var distancies = Carrera.CalcularDistancies(corredors);
        Carrera.MostrarDistancies(distancies);
    }
}
