using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructure.QueueLList
{
    public class Node{
        public string Data { get; set; }
        public Node Next { get; set; }

        public Node(string data)
        {
            Data=data;
            Next = null;
        }
    }   
    public class QueueLList
    {
        
    }
}