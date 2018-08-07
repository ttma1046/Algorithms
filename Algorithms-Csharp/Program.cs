namespace Algorithms_Csharp
{
    class Program
    {


        int fib(int n, int[] memo)
        {
            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else if (memo[n] == 0)
            {
                memo[n] = fib(n - 1, memo) + fib(n - 2, memo);
            }

            return memo[n];
        }

        // SPACE COMPLEXITY(aka memory usage)
        // Non-memoized: O(n)
        // Memoized: O(n)
        int countPaths(bool[][] grid, int row, int col)
        {
            // if (!validSquare(grid, row, col)) return 0;
            // if (isAtEnd(grid, row, col)) return 1;
            return countPaths(grid, row + 1, col) + countPaths(grid, row, col + 1);
        }

        // Runtime:
        // Recursive*(simple): O(2^n^2)
        // Memoization: O(n^2)
        int countPathsV2(bool[][] grid, int row, int col, int[][] paths)
        {
            // if (!validSquare(grid, row, col)) return 0;
            // if (isAtEnd(grid, row, col)) return 1;
            if (paths[row][col] == 0)
            {
                paths[row][col] = countPathsV2(grid, row + 1, col, paths) + countPathsV2(grid, row, col + 1, paths);
            }
            return paths[row][col];
        }
    }
}
