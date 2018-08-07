namespace Algorithms_Csharp.array
{
    class ArrayLeftRotation
    {
        static int[] rotateLeft(int[] a, int d)
        {
            if (a == null || a.Length == 0) return a;
            if (d <= 0) { return a; }

            for (int j = 1; j <= d; j++)
            {
                int temp = a[0];
                for (int i = 0; i < a.Length - 1; i++)
                {
                    a[i] = a[i + 1];
                }
                a[a.Length - 1] = temp;
            }
            return a;
        }

        int[] leftRotate(int [] a, int rotatetime, int length)
        {
            int i, j, k, temp;
            // arr[] =
            // { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }
            // n = 12
            // d = 3
            // GCD of 12 and 3 is 3
            // first set
            // { 4, 2, 3, 7, 5, 6, 10, 8, 9, 1, 11, 12 }
            // second set
            // { 4, 5, 3, 7, 8, 6, 10, 11, 9, 1, 2, 12 }
            // third set
            // { 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3 }
            for (i = 0; i < GreatestCommonDivisor(rotatetime, length); i++)
            {
                /* move i-th values of blocks */
                temp = a[i];
                j = i;

                while (true)
                {
                    k = j + rotatetime;
                    if (k >= length)
                        k = k - length;
                    if (k == i)
                        break;
                    a[j] = a[k];
                    j = k;
                }

                a[j] = temp;
            }

            return a;
        }

        public static int GreatestCommonDivisor(int p, int q)
        {
            if (q == 0)
            {
                return p;
            }

            int r = p % q;

            return GreatestCommonDivisor(q, r);
        }
    }
}
