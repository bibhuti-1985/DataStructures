using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    public class AdjListGraph
    {
        private int _size;
        private bool _isUndirected;
        List<int>[] adjList;
        public AdjListGraph(int size, bool isUndirected = true)
        {
            _size = size;
            _isUndirected = isUndirected;
            adjList = new List<int>[_size];
            Init();
        }

        private void Init()
        {
            for(int i = 0; i < _size; i++)
            {
                adjList[i] = new List<int>();
            }
        }

        public void AddEdge(int u, int v)
        {
            if (adjList[u] == null)
                adjList[u] = new List<int>();

            adjList[u].Add(v);

            if (_isUndirected)
            {
                if (adjList[v] == null)
                    adjList[v] = new List<int>();

                adjList[v].Add(u);
            }
        }

        public void Dfs(int u)
        {
            var startingNode = u;
            var visited = new bool[adjList.Length];
            var stack = new Stack<int>();
            stack.Push(startingNode);
            visited[startingNode] = true;

            while (stack.Count > 0)
            {
                var curNode = stack.Pop();
                Console.WriteLine(curNode);
                foreach(var neighbour in adjList[curNode])
                {
                    if (!visited[neighbour])
                    {
                        stack.Push(neighbour);
                        visited[neighbour] = true;
                    }
                }
            }
        }

        //public void BfsRecursive(int startingNode, bool[] visited)
        //{
        //    if (visited[startingNode])
        //        return;

        //    Console.WriteLine(startingNode);
        //    visited[startingNode] = true;
        //    foreach (var neighbour in adjList[startingNode])
        //    {
        //        BfsRecursive(neighbour, visited);
        //    }
        //}

        public void DfsRecursive(int startingNode, bool[] visited)
        {
            if (!visited[startingNode])
                Console.WriteLine(startingNode);

            visited[startingNode] = true;

            foreach (var neighbour in adjList[startingNode])
            {
                if (!visited[neighbour])
                {
                    DfsRecursive(neighbour, visited);
                }
            }
        }

        public void Bfs(int u)
        {
            var startingNode = u;
            var visited = new bool[adjList.Length];
            var queue = new Queue<int>();
            queue.Enqueue(startingNode);
            visited[startingNode] = true;

            while (queue.Count > 0)
            {
                var curNode = queue.Dequeue();
                Console.WriteLine(curNode);
                foreach(var neighbour in adjList[curNode])
                {
                    if (!visited[neighbour])
                    {
                        queue.Enqueue(neighbour);
                        visited[neighbour] = true;
                    }
                }
            }
        }
    }
}
