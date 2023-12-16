using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabWork_3
{
    class GraphAdjMatrix
    {
        private int[,] graph; //матрица смежности
        private int vertices; //вершины
        /// <summary>
        /// Массив для восстановления кратчайшего пути
        /// </summary>
        int[] finalWay;
        
        public int[,] AdjacencyMatrix { get => graph; }

        public GraphAdjMatrix(int vertices)//конструктор матрицы
        {
            this.vertices = vertices;
            graph = new int[vertices, vertices];
        }
        /// <summary>
        /// Связь вершин невзвешенного графа
        /// </summary>       
        public void AddEdge(int source, int destination)//связывание 2х вершин ребрами
        {
            graph[source, destination] = 1; //путь от одной вершины к другой
            graph[destination, source] = 1; //обратная связь между этими 2 вершинами
            finalWay = new int[graph.GetLength(1)];
        }
        /// <summary>
        /// Связь вершин взвешенного графа
        /// </summary>       
        public void AddEdge(int source, int destination, int weight)//связывание 2х вершин ребрами с весом
        {
            graph[source, destination] = weight; //путь от одной вершины к другой
            graph[destination, source] = weight; //обратная связь между этими 2 вершинами
            finalWay = new int[graph.GetLength(0)];
        }
        public void PrintGraph()
        {
            Console.Write("    ");
            for (int top = 0; top < vertices; top++)
            {
                Console.Write(top + "   ");
            }
            Console.WriteLine();
            for (int i = 0; i < vertices; i++)
            {
                Console.Write(i + "   ");
                for (int j = 0; j < vertices; j++)
                {
                    
                    Console.Write(graph[i, j] + "   "); //вывожу вершины и связь между ними
                    
                }
               
                Console.WriteLine();
            }
        }       
    }
}
