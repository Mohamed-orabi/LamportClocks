namespace LamportClocks
{
    internal class LamportClock
    {
        private int counter = 0;

        public int Tick()
        {
            return ++counter;
        }

        public int getCurrentTime()
        {
            return counter;
        }

        public void RecevingMessage(int icomingCounter)
        {
            counter = Math.Max(counter, icomingCounter) + 1;
        }
    }
}
