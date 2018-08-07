using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Csharp.resursionanddp
{
    class CoinChange
    {
        public static long MakeChange(int[] coins, int money, int index)
        {
            int amountWithCoin = 0;
            long ways = 0;
            while (amountWithCoin <= money)
            {
                int remaining = money - amountWithCoin;
                ways += MakeChange(coins, remaining, index + 1);
                amountWithCoin += coins[index];
            }
            return ways;
        }

        static void Main(string[] args)
        {
            MakeChange(new int[] { 25, 10, 5, 1 }, 27, 0);
        }
    }
}
