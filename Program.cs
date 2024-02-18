class Program
{
    static void Main(string[] args)
    {

        QueuesManipulation queues = new();
        queues.CreateQueue(5);

        //Circular using FIFO
        queues.Enqueue(10);
        queues.Enqueue(20);
        queues.Enqueue(30);
        queues.Enqueue(40);
        System.Console.WriteLine("deleted: " + queues.Dequeue());
        System.Console.WriteLine("deleted: " + queues.Dequeue());
        queues.Enqueue(90);
        queues.Enqueue(100);


        //DEqueue Like in java not using FIFO
        // queues.DEqueue(10);
        // queues.DEqueue(20);
        // queues.DEqueue(30);
        // queues.DEqueue(40);


        // System.Console.WriteLine("deleted: " + queues.DEdequeue());
        // System.Console.WriteLine("deleted: " + queues.DEdequeue());

        // queues.DEqueue(90);
        // queues.DEqueue(100);
        queues.Display();
    }
}
