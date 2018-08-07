using System.Collections.Generic;

public class Queue<T>
{             
    private Stack<T> inbox = new Stack<T>();
    private Stack<T> outbox = new Stack<T>();

    public void Enqueue(T item)
    {
        inbox.Push(item);  // Add item.
    }

    public T Dequeue() // Get "oldest" item and remove it
    {
        ShiftStacks();
        return outbox.Pop();
    }

    public T Peek() // Get "oldest" item
    {  
        ShiftStacks();
        return outbox.Peek();
    }

    private void ShiftStacks()  // move elements from stackNewest to stackOldest
    {
        if (outbox.Count == 0)
        {
            while (inbox.Count != 0)
            {
                outbox.Push(inbox.Pop());
            }
        }
    }
}

public class QueueV2<T>
{      
    private Stack<T> inbox = new Stack<T>();
    private Stack<T> outbox = new Stack<T>();

    public void Enqueue(T item)
    {
        while (inbox.Count != 0)
        {
            outbox.Push(inbox.Pop());
        }

        inbox.Push(item);

        while (outbox.Count != 0)
        {
            inbox.Push(outbox.Pop());
        }
    }

    public T Dequeue()
    {
        return inbox.Pop();
    }

    static void Main(string[] args)
    {
        new QueueV2<int>().Enqueue(1);
    }
}

