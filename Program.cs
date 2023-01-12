namespace LinkedListDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Console.WriteLine("Current Size of the List is: " + list.getListSize());

            list.insertNode(56);
            list.insertNode(30);
            list.insertNode(70);
            list.printNodes();


            Console.WriteLine("Deleting First node :");
            list.deleteFirstNode();
            list.printNodes();
        }
    }
}