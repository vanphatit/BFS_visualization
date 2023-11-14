using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_visualization
{
    public class Node<T>
    {
        //Data
        public int value { get; set; }
        //Link
        public Node<int> pointer { get; internal set; }
        //Contructor
        public Node(int value)
        {
            this.value = value;
            this.pointer = null;
        }

    }
}
