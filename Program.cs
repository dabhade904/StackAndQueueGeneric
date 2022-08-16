namespace StatckAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welocme message");
            StackUsingLinkedList<int> stack = new StackUsingLinkedList<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine("Stack Structure- ");
            stack.Display();
            Console.ReadLine();


        }
    }
}