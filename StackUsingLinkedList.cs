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

        // remove at the beginning 
        public void pop() 
        {
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            // update the top pointer to 
            // point to the next node 
            top = top.next;
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
