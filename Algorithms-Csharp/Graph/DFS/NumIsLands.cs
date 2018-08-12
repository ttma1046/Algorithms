using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Csharp.Graph.DFS
{
    class NumIsLands
    {
        private bool[,] visited;
        private int numRow;
        private int numCol;

        public int NumIslands(char[,] grid)
        {
            if (grid == null || grid.Length < 1 || grid.GetLength(1) < 1)
            {
                return 0;
            }

            int total = 0;
            numRow = grid.GetLength(0);
            numCol = grid.GetLength(1);

            visited = new bool[numRow, numCol];

            for (int i = 0; i < numRow; ++i)
            {
                for (int j = 0; j < numCol; ++j)
                {
                    if (!visited[i, j] && grid[i, j] == '1')
                    {
                        ++total;

                        dfs(grid, i, j);
                    }
                }
            }

            return total;
        }

        private void dfs(char[,] grid, int i, int j)
        {
            if (i < 0 || i >= numRow || j < 0 || j >= numCol || grid[i, j] == '0' || visited[i, j])
            {
                return;
            }

            visited[i, j] = true;
            dfs(grid, i + 1, j);
            dfs(grid, i - 1, j);
            dfs(grid, i, j + 1);
            dfs(grid, i, j - 1);
        }

        public static void main(string[] args)
        {
            var grid = new char[,] { { '1', '1', '1', '1', '0' }, { '1', '1', '0', '1', '0' }, { '1', '1', '0', '0', '0' }, { '0', '0', '0', '0', '0'} };
            Console.WriteLine(new NumIsLands().NumIslands(grid));
        }
    }
}
