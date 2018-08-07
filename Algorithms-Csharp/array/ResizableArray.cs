namespace Algorithms_Csharp.array
{
    using System;

    class ResizableArray
    {
        private int[] items;
        private int size;

        int[] _oldArray = new int[10];

        int[] _newArray = new int[20];

        public void copy()
        {
            for (int i = 0; i < _oldArray.Length; i++)
            {
                _newArray[i] = _oldArray[i];
            }

            _oldArray = _newArray;
        }

        //oldArray 表示当前存储元素的数组
        //size 表示当前元素个数
        public void add(int index, int e)
        {
            if (index > size || index < 0)
            {
                Console.WriteLine("位置不合法...");
            }

            //如果数组已经满了 就扩容
            if (size >= _oldArray.Length)
            {
                // 扩容函数可参考代码1
            }

            for (int i = size - 1; i >= index; i--)
            {
                _oldArray[i + 1] = _oldArray[i];
            }

            //将数组elementData从位置index的所有元素往后移一位
            // System.arraycopy(oldArray, index, oldArray, index + 1,size - index);

            _oldArray[index] = e;

            size++;
        }

        public int Size()
        {
            return size;
        }

        /*
        public void set(int index, int item)
        {
            if (index < 0 || index >= size)
            {
                throw new ArrayIndexOutOfBoundsException(index);
            }
            items[index] = item;
        }

        public void append(int item)
        {
            ensureExtraCapacity();
            items[size] = item;
            size++;
        }
        public int get(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new ArrayIndexOutOfBoundsException(index);
            }
            return items[index];
        }

        private void ensureExtraCapacity()
        {
            if (size == items.Length)
            {
                int[] copy = new int[size * 2];
                System.arraycopy(items, 0, copy, 0, size);
                items = copy;
            }
        }
        */
    }
}
