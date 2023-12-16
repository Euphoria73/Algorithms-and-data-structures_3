using Newtonsoft.Json;
using System;


namespace LabWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DFS
            GraphAdjList gAL = new GraphAdjList(8);
            gAL.AddEdge(0, 0);
            gAL.AddEdge(1, 2);
            gAL.AddEdge(1, 3);
            gAL.AddEdge(2, 3);
            gAL.AddEdge(3, 4);
            gAL.AddEdge(4, 5);
            gAL.AddEdge(5, 6);
            gAL.AddEdge(5, 7);
            gAL.AddEdge(6, 7);
            gAL.AddEdge(7, 1);
            Console.WriteLine("Вывожу список смежности:");
            gAL.PrintGraph();
            Console.WriteLine("Введите номер вершины из списка");
            int find = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выполняется обход в глубину:");
            gAL.DFS(find);
            #endregion
            #region Dijkstra
            //GraphAdjMatrix gAM = new GraphAdjMatrix(8);
            //gAM.AddEdge(0, 1, 2);
            //gAM.AddEdge(1, 2, 10);
            //gAM.AddEdge(1, 3, 5);
            //gAM.AddEdge(2, 4, 7);
            //gAM.AddEdge(3, 2, 9);
            //gAM.AddEdge(4, 5, 23);
            //gAM.AddEdge(5, 6, 12);
            //gAM.AddEdge(5, 7, 4);
            //gAM.AddEdge(6, 7, 8);
            //gAM.AddEdge(7, 1, 7);
            //gAM.PrintGraph();
            //Console.WriteLine("Метод Дейкстры");
            //Console.WriteLine("Введите номер вершины для вычисления пути:");
            //int destination = Convert.ToInt32(Console.ReadLine());
            //Dijkstra.DijkstraAlgoritm(gAM.AdjacencyMatrix, destination, 8);
            #endregion
            #region BiHeap
            //var bheap = new BiHeap();
            //var rnd = new Random();

            ////заполняю кучу данными
            //for (int i = 0; i < 10; i++)
            //{
            //    bheap.Add(rnd.Next(0, 100));
            //}

            //bheap.Print();
            //Console.WriteLine("Корень кучи: "+ bheap.GetMax());
            #endregion
        }
    }
}
