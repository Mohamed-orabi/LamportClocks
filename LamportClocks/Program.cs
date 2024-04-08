namespace LamportClocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initializing two nodes with Lamport clocks
            LamportClock nodeA = new LamportClock();
            LamportClock nodeB = new LamportClock();

            // Node A performs an operation
            nodeA.Tick();
            Console.WriteLine($"Node A's time after an event: {nodeA.getCurrentTime()}");

            // Node A sends a message to Node B
            int messageTime = nodeA.Tick(); // Increment before sending
            Console.WriteLine($"Node A sends a message with time: {messageTime}");

            // Node B receives the message
            nodeB.RecevingMessage(messageTime);
            Console.WriteLine($"Node B's time after receiving the message: {nodeB.getCurrentTime()}");

            // Node B performs an operation
            nodeB.Tick();
            Console.WriteLine($"Node B's time after an event: {nodeB.getCurrentTime()}");

        }
    }
}
