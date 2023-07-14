using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class PeekTest
    {
        [Fact]
        public void PeekTestInQueue() 
        { 
        
            var p = new Queue<int>();
            p.Enqueue(1);
            p.Enqueue(2);
            p.Enqueue(3);
            var firstItem = p.Peek();
            Assert.Equal(1, firstItem);

        }
    }
}
