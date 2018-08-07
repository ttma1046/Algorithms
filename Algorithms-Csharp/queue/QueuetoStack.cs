using System.Collections.Generic;

    class QueuetoStack
    {
        private System.Collections.Generic.Queue<int> queue1 = new System.Collections.Generic.Queue<int>();
        private System.Collections.Generic.Queue<int> queue2 = new System.Collections.Generic.Queue<int>();

        public void Push(int input)
        {
            queue2.Enqueue(input);

            while (queue1.Count > 0)
            {
                queue2.Enqueue(queue1.Dequeue());
            }

            var temp = queue1;
            queue1 = queue2;
            queue2 = temp;

        }

        public void Pop(int input)
        {
            queue1.Dequeue();
        }
    }

