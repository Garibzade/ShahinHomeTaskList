namespace HomeTaskList
{
    internal class Program
    {
        static void Main(string[] args)
        {
          IntArrayList list = new IntArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list.ToString());
        }
    }
}
