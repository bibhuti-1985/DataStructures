using DataStructures.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //AdjMatrixGraph graph = new AdjMatrixGraph(4);
            //graph.AddEdge(0, 1);
            //graph.AddEdge(0, 3);
            //graph.AddEdge(1, 3);
            //graph.AddEdge(2, 3);
            //Console.WriteLine("\nDFS\n");
            //graph.Dfs(0);
            //Console.WriteLine("\nBFS\n");
            //graph.Bfs(0);

            AdjListGraph listGraph = new AdjListGraph(5, false);
            listGraph.AddEdge(0, 2);
            listGraph.AddEdge(0, 3);
            listGraph.AddEdge(1, 0);
            //listGraph.AddEdge(1, 3);
            //listGraph.AddEdge(3, 4);
            listGraph.AddEdge(2, 1);
            listGraph.AddEdge(1, 4);
            //listGraph.AddEdge(3, 3);
            //listGraph.AddEdge(4, 1);
            //listGraph.AddEdge(4, 5);
            Console.WriteLine("\nAdjancy List DFS\n");
            listGraph.Dfs(0);
            //Console.WriteLine("Adjancy List BFS\n");
            //listGraph.Bfs(0);
            //Console.WriteLine("Adjancy List BFS Recursive\n");
            //listGraph.BfsRecursive(0, new bool[5]);
            Console.WriteLine("Adjancy List DFS Recursive\n");

            listGraph.DfsRecursive(0, new bool[6]);

            Console.ReadKey();
        }
    }
}
