using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_3
{
    static class Dijkstra
    {

        public static void DijkstraAlgoritm(int[,] graph, int source, int verticesCount)
        {
            int[] distance = new int[verticesCount]; //сюда будут заноситься найденные кратчайшие пути
            bool[] visitedVert = new bool[verticesCount]; //для хранения информации о посещенных вершинах

            for (int i = 0; i < verticesCount; i++)
            {
                distance[i] = int.MaxValue; //заполняем максимальным значением каждую точку для исключения ошибки
                visitedVert[i] = false;
            }

            distance[source] = 0; //вес исходной точки равно нулю, т.к. у неё нет ребёр (не предусматриваются петли в себя)

            for (int count = 0; count < verticesCount - 1; count++)
            {
                int u = MinimumDistance(distance, visitedVert, verticesCount); //пробегаемся по каждой точке и находим минимальное
                visitedVert[u] = true;                                         //значение между ними, другие игнорируем

                for (int v = 0; v < verticesCount; v++)
                    if (!visitedVert[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                        distance[v] = distance[u] + graph[u, v]; //складываем значения посещенной точки и соседних
            }

            Print(distance, verticesCount);
        }
        private static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < verticesCount; v++)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        private static void Print(int[] distance, int verticesCount)
        {
            Console.WriteLine("Вершина    Расстояние от источника");

            for (int i = 0; i < verticesCount; i++)
                Console.WriteLine("{0}\t  {1}", i, distance[i]);
        }


    }
}
