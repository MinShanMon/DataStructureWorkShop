using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LinkedList.DataStructure.StackLList
{
    public class Node{
            public string Data { set; get; }
            public Node Next { get; set; }

            public Node(string data)
            {
                Data = data;
                Next = null;
            }
    }

    public class StackLList
    {
        

        public Node Head { get; set; }

        private int numElements;

        public StackLList()
        {
            Head = null;
            numElements = 0;
        }

        public void push(string element){
            Node newNode = new Node(element);
            if(numElements == 0){
                Head = newNode;
            }
            else{
                newNode.Next = Head;
                Head = newNode;
            }
            numElements++;
        }

        public void pop(){
            Head = Head.Next;
            numElements--;
        }

        public int Count(){
            return numElements;
        }

        public Node peek(){
            return Head;
        }


    }
}