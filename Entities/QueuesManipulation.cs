class QueuesManipulation
{
    Queue queue = null;

    public void CreateQueue(int size)
    {
        queue = new() { Q = new int[size], Size = size };
    }

    //circular queue all O(1)
    public void Enqueue(int x)
    {

        if ((queue.Rear + 1) % queue.Size == queue.Front) System.Console.WriteLine("Queue is full");
        else
        {
            queue.Rear = (queue.Rear + 1) % queue.Size;
            queue.Q[queue.Rear] = x;
        }
    }
    public int Dequeue()
    {
        int x = -1;
        if (queue.Rear == queue.Front) System.Console.WriteLine("Queue is empty");
        else
        {
            queue.Front = (queue.Front + 1) % queue.Size;
            x = queue.Q[queue.Front];
        }
        return x;
    }

    //those methods allows you to add using Rear or Front 
    public void DEqueue(int x)
    {

        if (queue.Rear != queue.Size - 1)
        {
            queue.Rear++;
            queue.Q[queue.Rear] = x;
        }
        else if (queue.Front != -1)
        {
            queue.Q[queue.Front] = x;
            queue.Front--;
        }
        else System.Console.WriteLine("Queue is full");

    }
    public int DEdequeue()
    {
        int x = -1;
        if (queue.Rear == queue.Front) System.Console.WriteLine("Queue is empty");
        else
        {
            queue.Front++;
            x = queue.Q[queue.Front];
        }
        return x;
    }

    public void Display()
    {
        int i = queue.Front + 1;
        do
        {
            System.Console.Write(queue.Q[i] + " ");
            i = (i + 1) % queue.Size;
        } while (i != (queue.Rear + 1) % queue.Size);
        System.Console.WriteLine();
    }
}