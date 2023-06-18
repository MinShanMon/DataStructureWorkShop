

using DataStructure.BST2;
using DataStructure.BSTB;
using DataStructure.Delimiters;
using LinkedList.DataStructure.QueueLList;
using LinkedList.DataStructure.StackLList;

public class Program
{
    public static void Main(string[] args)
    {
            //Linklist
            // LList myList = new LList();
            // myList.Add("FOPCS");
            // myList.Add("OOPCS");
            // myList.Insert(1, "MVC.NET");
            // if (myList.Contains("OOPCS"))
            //     myList.Insert(3, "Design");
            // myList.Insert(1, "Data Structures");
            // myList.Replace(3, "Java");
            // myList.RemoveAt(1);
            // myList.Replace(1, "Android");

            // Console.WriteLine();
            // for (int i = 0; i < myList.Count(); i++)
            //     Console.WriteLine(myList.GetAt(i));

            //stackLinklist
            // StackLList Slist = new StackLList();
            // Slist.push("1");
            // Slist.push("2");
            // Slist.push("3");
            // Slist.push("4");
            // Slist.pop();
            // LinkedList.DataStructure.StackLList.Node peek = Slist.peek();
        
            //queueLList
            // QueueLList QList = new QueueLList();
            // QList.Enqueue("1");
            // QList.Enqueue("2");
            // QList.Enqueue("3");
            // QList.Enqueue("4");
            // QList.Dequeue();
            // LinkedList.DataStructure.QueueLList.Node node =  QList.Peek();


            // Delimiters.Run();

            //BSTB
            int[] keysB = new int[] { 27, 14, 35, 10, 19, 31, 42};
            BinaryTree bstb = new BinaryTree();

            for(int i = 0; i<keysB.Length; i++){
                bstb.Insert(keysB[i]);
            }

            bstb.PrintBFS();
            //BST2
            //int[] keys = new int[] { 27, 14, 35, 10, 19, 31, 42, 50, 60, 100, 123, 52, 53, 54, 55, 56, 200 };
            int[] keys = new int[] { 27, 14, 35, 10, 19, 31, 42};

            BST bst = new BST();
            

            // build BST
            for (int i = 0; i < keys.Length; i++) {
                bst.Insert(new DataStructure.BST2.Node(keys[i]));
            }

            // test Find method
            // int[] data = { 10, 11, 19, 30 };

            // foreach (int key in data) {
            //     if (bst.Find(key) == null) {
            //         Console.WriteLine("Key '{0}' is NOT found.", key);
            //     }
            //     else {
            //         Console.WriteLine("Key '{0}' is found.", key);
            //     }
            // }

            // bst.DepthFirst(1);
            // bst.DepthFirst(2);
            // bst.DepthFirst(3);

            //bst.BreadthFirst();

            // System.Console.WriteLine(Factorial(4));
 
    }

        // public static int Factorial(int n)
        // {
        // if (n == 0) {
        // return 1; }
        //     return n * Factorial(n - 1);
        // }

}