namespace LinkedListDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Console.WriteLine("Current Size of the List is: " + list.getListSize());

            list.insertNode(56);

            list.insertNode(70);
            list.printNodes();

            Console.WriteLine("Adding 30 at 1st Location");
            list.insertNth(30, 1);
            list.printNodes();
        }
    }
}