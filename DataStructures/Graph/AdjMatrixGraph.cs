using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    public class AdjMatrixGraph
    {
        private int _size;
        private bool _isUndirected;
        int[][] adjMatrix;
        public AdjMatrixGraph(int size, bool isUndirected = true)
        {
            _size = size;
            adjMatrix = new int[size][];
            _isUndirected = isUndirected;

            Init();
        }

        private void Init()
        {
            for (int i = 0; i < adjMatrix.Length; i++)
            {
                adjMatrix[i] = new int[_size];
            }
        }

        public void AddEdge(int u, int v)
        {
            adjMatrix[u][v] = 1;
            if(_isUndirected)
            {
                adjMatrix[v][u] = 1;
            }
        }

        public void Dfs(int u)
        {
            var startingNode = u;
            var visited = new bool[adjMatrix.Length];
            var stack = new Stack<int>();
            stack.Push(startingNode);
            visited[startingNode] = true;

            while(stack.Count > 0)
            {
                var curNode = stack.Pop();
                Console.WriteLine(curNode);
                for(int j = 0; j < adjMatrix[curNode].Length; j++)
                {
                    if (!visited[j] && adjMatrix[curNode][j] == 1)
                    {
                        stack.Push(j);
                        visited[j] = true;
                    }
                }
            }
        }

        public void Bfs(int u)
        {
            var startingNode = u;
            var visited = new bool[adjMatrix.Length];
            var queue = new Queue<int>();
            queue.Enqueue(startingNode);
            visited[startingNode] = true;

            while (queue.Count > 0)
            {
                var curNode = queue.Dequeue();
                Console.WriteLine(curNode);
                for (int j = 0; j < adjMatrix[curNode].Length; j++)
                {
                    if (!visited[j] && adjMatrix[curNode][j] == 1)
                    {
                        queue.Enqueue(j);
                        visited[j] = true;
                    }
                }
            }
        }
    }
}
