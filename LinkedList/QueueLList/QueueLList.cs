using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkedList.DataStructure.QueueLList
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
        public Node Head { get; set; }
        private int numElements;

        public QueueLList(){
            Head=null;
            numElements=0;
        }

        public void Enqueue(string element){
            Node newNode = new Node(element);
            if(numElements==0){
                Head = newNode;
            }
            else{
                newNode.Next = Head;
                Head = newNode;
            }
            numElements++;
        }

        public void Dequeue(){
            if(numElements-1>=0){
                Node curNode = Head;
                for(int i = 0; i<numElements-2; i++){
                    curNode=curNode.Next;
                }
                if(numElements-1==0){
                    Head=Head.Next;
                }
                else{
                    curNode.Next = null;
                }
                numElements--;
            }
            
        }

        public Node Peek(){
            try{
                if(numElements-1>=0){
                Node curNode = Head;
                for(int i = 0; i<numElements-1;i++){
                    curNode = curNode.Next;
                }
                return curNode;
                }
                else{
                    return null;
                }
            }
            catch(Exception e){
                Console.WriteLine("error");
                return null;
            }
            
        }
    }
}