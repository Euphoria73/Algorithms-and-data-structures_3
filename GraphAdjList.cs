using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace LabWork_3
{
    class GraphAdjList
    {
        private List<int>[] adjacencyList; //список смежности
        private int vertices;              // Number of vertices

        public List<int>[] AdjacencyList { get => adjacencyList; }

        public GraphAdjList(int vertices)
        {
            adjacencyList = new List<int>[vertices];
            for (int i = 0; i < vertices; i++)
            {
                adjacencyList[i] = new List<int>();
            }
            this.vertices = vertices;
        }
        public void AddEdge(int u, int v)
        {
            adjacencyList[u].Add(v); //довавление ребра вершины
        }
        public void PrintGraph()
        {
            for (int i = 0; i < adjacencyList.Length; i++)
            {
                Console.Write(i + ": "); //вывожу вершины графа
                for (int j = 0; j < adjacencyList[i].Count; j++)
                {
                    Console.Write(adjacencyList[i][j] + " "); //вывожу связи данной вершины графа
                }
                Console.WriteLine();
            }
        }
        public void DFS(int startVertex)
        {
            bool[] visited = new bool[vertices];
            DFSUtil(startVertex, visited);
        }
        private void DFSUtil(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write(v + " ");

            foreach (int neighbor in adjacencyList[v])
            {
                if (!visited[neighbor])
                    DFSUtil(neighbor, visited);
            }
        }

    }
}
