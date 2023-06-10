using DataStructure.StackLList;

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

            StackLList Slist = new StackLList();
            Slist.push("1");
            Slist.push("2");
            Slist.push("3");
            Slist.push("4");
            Slist.pop();
            DataStructure.StackLList.Node peek = Slist.peek();
        
    }
}