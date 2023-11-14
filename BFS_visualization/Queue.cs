using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_visualization
{
    public class Queue<T>
    {
        public Node<int> FL;
        public Node<int> LL;

        public Queue()
        {
            FL = null;
            LL = null;

        }
    }
}
