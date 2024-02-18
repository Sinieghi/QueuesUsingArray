class Queue
{
    public int Size { get; set; }
    //If you are using DEqueue or linear Queue Dequeue you have to use those assignment as -1
    //Ele use them as 0 for circular queue in Array
    public int Front { get; set; } = 0;
    public int Rear { get; set; } = 0;
    public int[] Q { get; set; }
}