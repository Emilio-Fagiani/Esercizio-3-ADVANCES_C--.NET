namespace Test
{
    public class EnqueueTest
    {
        [Fact]
        public void EnqueueIntInMyQueue()
        {
            var myQueue = new Queue<int>();
            myQueue.Enqueue(10);
            
            Assert.Equal(10, myQueue.Last());

        }
        [Fact]
        public void EnqueueStringInMyQueue()
        {
            var myQueue = new Queue<string>();
            myQueue.Enqueue("Ciao");
            
            Assert.Equal("Ciao", myQueue.Last());

        }
        [Fact]
        public void EnqueueItemInMyQueue()
        {
            Object item = new Object();
            var myQueue = new Queue<Object>();
            myQueue.Enqueue(item);
            
            Assert.Equal(item, myQueue.Last());

        }

    }
}