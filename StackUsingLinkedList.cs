using StackAndQueue;
namespace StatckAndQueue
{
    public class StackUsingLinkedList<T>
    {
        private Node<T> top;
        public StackUsingLinkedList()
        {
            this.top = null;
        }
        public void Push(T data)
        {
            Node<T> temp = new Node<T>(data);
            if (temp == null)
            {
                Console.Write("\n Stack Overflow");
                return;
            }
            temp.data = data;
            temp.next = top;
            top = temp;
        }
        public void Display()
        {
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                Node<T> temp = top;
                while (temp != null)
                {
                    Console.Write("{0}->", temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
