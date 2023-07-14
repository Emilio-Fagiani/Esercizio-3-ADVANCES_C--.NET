using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
 
    public class DequeueTest
    {
        [Fact]
        public void DenqueueTest()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            int itemDequeue = queue.Dequeue();
            Assert.Equal(1,itemDequeue);
            Assert.Equal(3, queue.Count);
        }


    }
}
